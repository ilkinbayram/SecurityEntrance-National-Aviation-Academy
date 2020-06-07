using SecureEntrance.DesktopUI.DesktopUI_Entities;
using SecureEntrance.DesktopUI.Entities;
using SecureEntrance.DesktopUI.Managers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureEntrance.DesktopUI
{
    public partial class FormAppLogin : Form
    {
        public FormAppLogin()
        {
            CurrentFormManager.FormLogin = this;
            InitializeComponent();
        }

        WorkerManager workerManager = new WorkerManager();
        LogSystemManager logSystemManager = new LogSystemManager();
        Worker worker = null;
        private void FormAppLogin_Load(object sender, EventArgs e)
        {

        }

        private void FormAppLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentFormManager.FormEntrance.Show();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            string userID = tbxUsername.Text;
            string passwordWorker = tbxPassword.Text;
            worker = workerManager.Get(x => x.IdentitySerie == userID);

            if (worker != null)
            {
                if (CryptoHelper.Crypto.VerifyHashedPassword(worker.Password, passwordWorker))
                {
                    CurrentModel.SerieWorkerID = worker.IdentitySerie;
                    if (logSystemManager.Get(x => x.WorkerEntered.AddDays(1) > DateTime.Now && x.SerieWorkerID == CurrentModel.SerieWorkerID) == null)
                    {
                        LogSystem logSystemNew = new LogSystem
                        {
                            CountryID = CurrentModel.CountryID,
                            IsDeleted = false,
                            SerieWorkerID = CurrentModel.SerieWorkerID,
                            WorkerEntered = DateTime.Now,
                            WorkerExited = DateTime.Now
                        };
                        logSystemManager.Insert(logSystemNew);
                    }
                    FormWorkPanel workPanel = new FormWorkPanel();
                    workPanel.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Qeyd Etdiyiniz Agent Movcud Deyil !", "Login Informasiyasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Qeyd Etdiyiniz Agent Movcud Deyil !", "Login Informasiyasi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbxPassword_TextChanged(object sender, EventArgs e)
        {
            tbxPassword.PasswordChar = '✪';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CurrentFormManager.FormEntrance.Show();
            this.Hide();
        }
    }
}
