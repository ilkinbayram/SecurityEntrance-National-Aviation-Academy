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
    public partial class FormPassengerAbout : Form
    {
        public FormPassengerAbout()
        {
            InitializeComponent();
        }
        CountryManager countryManager = new CountryManager();
        private void FormPassengerAbout_Load(object sender, EventArgs e)
        {
            Passenger passenger = CurrentModel.Passenger;
            lblTurnedName.Text = passenger.Name;
            lblTurnedSurname.Text = passenger.Surname;
            lblTurnedNationality.Text = passenger.Nationality.CountryName;
            lblTurnedGender.Text = passenger.Gender == true ? "Kisi" : "Qadin";
            lblPassportCity.Text = countryManager.Get(x => x.ID == passenger.NowCountryID).CountryName;
            lblCurrentCity.Text = countryManager.Get(x => x.ID == CurrentModel.CountryID).CountryName;
            pbxTurnedImportant.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTurnedImportant.ImageLocation = "C:/Users/Developer/source/repos/SecureEntrance/SecureEntrance.DesktopUI/"+passenger.Image;
        }
    }
}
