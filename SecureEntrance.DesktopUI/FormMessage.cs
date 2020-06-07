using SecureEntrance.DesktopUI.DesktopUI_Entities;
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
    public partial class FormMessage : Form
    {
        public FormMessage()
        {
            CurrentFormManager.FormMessage = this;
            InitializeComponent();
        }

        private void FormMessage_Load(object sender, EventArgs e)
        {
            pcbError1.BackColor = System.Drawing.Color.Transparent;
            lblInfoError.BackColor = System.Drawing.Color.Transparent;
        }

        private void btnLookInfo_Click(object sender, EventArgs e)
        {
            FormPassengerAbout passengerAbout = new FormPassengerAbout();
            passengerAbout.Show();
        }

        private void btnBackToWork_Click(object sender, EventArgs e)
        {
            CurrentFormManager.FormWorkOn.Show();
            this.Close();
        }

        private void FormMessage_FormClosing(object sender, FormClosingEventArgs e)
        {
            CurrentFormManager.FormWorkOn.Show();
        }
    }
}
