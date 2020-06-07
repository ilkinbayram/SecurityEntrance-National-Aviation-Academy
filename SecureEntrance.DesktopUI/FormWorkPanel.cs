using SecureEntrance.DesktopUI.DesktopUI_Entities;
using SecureEntrance.DesktopUI.Entities;
using SecureEntrance.DesktopUI.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureEntrance.DesktopUI
{
    public partial class FormWorkPanel : Form
    {
        public FormWorkPanel()
        {
            CurrentFormManager.FormWorkOn = this;
            InitializeComponent();
        }

        PassengerManager passengerManager = new PassengerManager();
        CountryManager countryManager = new CountryManager();
        LogSystemManager logSysMan = new LogSystemManager();
        LogProcessManager logm = new LogProcessManager();
        private void FormWorkPanel_Load(object sender, EventArgs e)
        {
            lbIUserSecureNumber.BackColor = System.Drawing.Color.Transparent;
            gbxPassengerCard.BackColor = System.Drawing.Color.Transparent;
            gbxAirTraectory.BackColor = System.Drawing.Color.Transparent;

            gbxPassengerCard.Visible = false;
            gbxAirTraectory.Visible = false;
        }

        private void btnCheckUserExist_Click(object sender, EventArgs e)
        {
            string passengerID = tbxUserSecureNumber.Text;
            Passenger passenger = passengerManager.Get(x => x.IdentitySerie == passengerID);
            if (passenger == null)
            {
                MessageBox.Show("Qeyd Etdiyiniz Isimde Sernisin Movcud Deyil !", "Sernisin Yoxlama Melumati", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentModel.Passenger = passenger;
                rbtnIsChecked.Text = "YOXLANILIB";
                rbtnIsChecked.Checked = true;
                gbxPassengerCard.Visible = true;
                gbxAirTraectory.Visible = true;
                pbxPassengerImage.SizeMode = PictureBoxSizeMode.StretchImage;
                pbxPassengerImage.ImageLocation = "C:/Users/Developer/source/repos/SecureEntrance/SecureEntrance.DesktopUI/" + passenger.Image;
                lblTurnedFromCity.Text = countryManager.Get(x => x.ID == CurrentModel.CountryID).CountryName;
                cmbxToTheCity.Items.Clear();
                foreach (var item in countryManager.ListAll(x => x.IsDeleted == false))
                {
                    cmbxToTheCity.Items.Add(item.CountryName);
                }
                lblTurnedName.Text = passenger.Name;
                lblTurnedSurname.Text = passenger.Surname;
                lblTurnedNationality.Text = passenger.Nationality.CountryName;
                lblTurnedAge.Text = passenger.Age.ToString();
                lblTurnedGender.Text = passenger.Gender == true ? "Kisi" : "Qadin";
            }
        }

        private void btnFinalChecker_Click(object sender, EventArgs e)
        {
            if (CurrentModel.Passenger.NowCountryID == CurrentModel.CountryID)
            {
                if (!(cmbxToTheCity.SelectedIndex>=0))
                {
                    MessageBox.Show("Zehmet Olmasa Gedilen Olkeni Qeyd Edin!", "Melumatlandirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CurrentModel.Passenger.NowCountryID = countryManager.Get(x => x.ID == cmbxToTheCity.SelectedIndex + 1).ID;
                    passengerManager.Update(CurrentModel.Passenger);

                    LogProcess logProcess = new LogProcess();
                    logProcess.ActCode = (int)ActCode.UgurluSernisinKecidi;
                    logProcess.ProcessDateTime = DateTime.Now;
                    logProcess.SeriePassengerID = CurrentModel.Passenger.IdentitySerie;
                    logProcess.SerieWorkerID = CurrentModel.SerieWorkerID;
                    logm.Insert(logProcess);

                    CurrentModel.Passenger = null;
                    gbxPassengerCard.Visible = false;
                    gbxAirTraectory.Visible = false;
                    pcbSuccess.Visible = true;

                }
            }
            else
            {
                LogProcess lastChecking = logm.Get(x => x.ProcessDateTime.Day == DateTime.Now.Day && x.SeriePassengerID == CurrentModel.Passenger.IdentitySerie);
                if (lastChecking != null)
                {
                    MessageBox.Show("Bu Sernisin Artiq Qeydiyyatdan Kecmisdir", "Kecid Melumatlandirma", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    LogProcess logProcess = new LogProcess
                    {
                        ActCode = (int)ActCode.LokasiyaUyumsuzlugu,
                        ProcessDateTime = DateTime.Now,
                        SeriePassengerID = CurrentModel.Passenger.IdentitySerie,
                        SerieWorkerID = CurrentModel.SerieWorkerID
                    };
                    logm.Insert(logProcess);
                    FormMessage formMessage = new FormMessage();
                    formMessage.Show();
                    this.Hide();
                }

            }
        }

        private void tbxUserSecureNumber_TextChanged(object sender, EventArgs e)
        {
            CurrentModel.Passenger = null;
            rbtnIsChecked.Text = "YOXLANILMAYIB";
            rbtnIsChecked.Checked = false;
            gbxPassengerCard.Visible = false;
            gbxAirTraectory.Visible = false;
            pcbSuccess.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CurrentModel.Passenger = null;
            CurrentModel.GoingCountryID = -1;
            rbtnIsChecked.Text = "YOXLANILMAYIB";
            rbtnIsChecked.Checked = false;
            gbxPassengerCard.Visible = false;
            gbxAirTraectory.Visible = false;
            pcbSuccess.Visible = false;
        }

        private void FormWorkPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogSystem logSystem = logSysMan.ListAll(x=>x.SerieWorkerID==CurrentModel.SerieWorkerID).OrderByDescending(x=>x.WorkerEntered).FirstOrDefault();
            logSystem.WorkerExited = DateTime.Now;
            logSysMan.Update(logSystem);
            Application.Exit();
        }
    }
}
