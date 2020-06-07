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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureEntrance.DesktopUI
{
    public partial class FormEntrancePage : Form
    {

        public FormEntrancePage()
        {
            CurrentFormManager.FormEntrance = this;
            InitializeComponent();
        }

        LogSystemManager logSysMan = new LogSystemManager();


        private void FormEntrancePage_Load(object sender, EventArgs e)
        {
            lblStartInfo.BackColor = System.Drawing.Color.Transparent;
            TestManager test = new TestManager();

        }

        private void btnAze1_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 1;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnTur2_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 2;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnRus3_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 3;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnEng4_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 4;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnUkr5_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 5;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnJpn6_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 6;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnGer7_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 7;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnIta8_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 8;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnSpa9_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 9;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnFra10_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 10;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnGrc11_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 11;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnPor12_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 12;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnCzh13_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 13;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnNor14_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 14;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnGeo15_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 15;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnIra16_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 16;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnSrb17_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 17;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnBrs18_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 18;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnArg19_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 19;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void btnBel20_Click(object sender, EventArgs e)
        {
            CurrentModel.CountryID = 20;
            FormAppLogin appLogin = new FormAppLogin();
            appLogin.Show();
            this.Hide();
        }

        private void FormEntrancePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogSystem logSystem = logSysMan.ListAll(x => x.SerieWorkerID == CurrentModel.SerieWorkerID).OrderByDescending(x => x.WorkerEntered).FirstOrDefault();
            logSystem.WorkerExited = DateTime.Now;
            logSysMan.Update(logSystem);
        }
    }
}
