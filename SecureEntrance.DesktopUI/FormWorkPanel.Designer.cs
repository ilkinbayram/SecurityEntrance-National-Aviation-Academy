namespace SecureEntrance.DesktopUI
{
    partial class FormWorkPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWorkPanel));
            this.pbxPassengerImage = new System.Windows.Forms.PictureBox();
            this.tbxUserSecureNumber = new System.Windows.Forms.TextBox();
            this.lbIUserSecureNumber = new System.Windows.Forms.Label();
            this.gbxPassengerCard = new System.Windows.Forms.GroupBox();
            this.lblTurnedGender = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblTurnedAge = new System.Windows.Forms.Label();
            this.lblTurnedNationality = new System.Windows.Forms.Label();
            this.lblTurnedSurname = new System.Windows.Forms.Label();
            this.lblTurnedName = new System.Windows.Forms.Label();
            this.lblAgePs = new System.Windows.Forms.Label();
            this.lblNationalityPS = new System.Windows.Forms.Label();
            this.lblSurnamePs = new System.Windows.Forms.Label();
            this.lblNamePs = new System.Windows.Forms.Label();
            this.btnCheckUserExist = new System.Windows.Forms.Button();
            this.rbtnIsChecked = new System.Windows.Forms.RadioButton();
            this.cmbxToTheCity = new System.Windows.Forms.ComboBox();
            this.gbxAirTraectory = new System.Windows.Forms.GroupBox();
            this.lblTurnedFromCity = new System.Windows.Forms.Label();
            this.btnFinalChecker = new System.Windows.Forms.Button();
            this.lblToCity = new System.Windows.Forms.Label();
            this.lblFromCity = new System.Windows.Forms.Label();
            this.pcbSuccess = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassengerImage)).BeginInit();
            this.gbxPassengerCard.SuspendLayout();
            this.gbxAirTraectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSuccess)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxPassengerImage
            // 
            this.pbxPassengerImage.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxPassengerImage.ErrorImage")));
            this.pbxPassengerImage.InitialImage = null;
            this.pbxPassengerImage.Location = new System.Drawing.Point(393, 54);
            this.pbxPassengerImage.Name = "pbxPassengerImage";
            this.pbxPassengerImage.Size = new System.Drawing.Size(136, 181);
            this.pbxPassengerImage.TabIndex = 0;
            this.pbxPassengerImage.TabStop = false;
            // 
            // tbxUserSecureNumber
            // 
            this.tbxUserSecureNumber.Location = new System.Drawing.Point(744, 50);
            this.tbxUserSecureNumber.Name = "tbxUserSecureNumber";
            this.tbxUserSecureNumber.Size = new System.Drawing.Size(233, 20);
            this.tbxUserSecureNumber.TabIndex = 1;
            this.tbxUserSecureNumber.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxUserSecureNumber_MouseClick);
            this.tbxUserSecureNumber.TextChanged += new System.EventHandler(this.tbxUserSecureNumber_TextChanged);
            // 
            // lbIUserSecureNumber
            // 
            this.lbIUserSecureNumber.AutoSize = true;
            this.lbIUserSecureNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbIUserSecureNumber.Font = new System.Drawing.Font("MS Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIUserSecureNumber.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbIUserSecureNumber.Location = new System.Drawing.Point(335, 48);
            this.lbIUserSecureNumber.Name = "lbIUserSecureNumber";
            this.lbIUserSecureNumber.Size = new System.Drawing.Size(350, 19);
            this.lbIUserSecureNumber.TabIndex = 2;
            this.lbIUserSecureNumber.Text = "Sərnişin İdentifikasiya Nömrəsi";
            // 
            // gbxPassengerCard
            // 
            this.gbxPassengerCard.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.gbxPassengerCard.Controls.Add(this.lblTurnedGender);
            this.gbxPassengerCard.Controls.Add(this.lblGender);
            this.gbxPassengerCard.Controls.Add(this.lblTurnedAge);
            this.gbxPassengerCard.Controls.Add(this.lblTurnedNationality);
            this.gbxPassengerCard.Controls.Add(this.lblTurnedSurname);
            this.gbxPassengerCard.Controls.Add(this.lblTurnedName);
            this.gbxPassengerCard.Controls.Add(this.lblAgePs);
            this.gbxPassengerCard.Controls.Add(this.lblNationalityPS);
            this.gbxPassengerCard.Controls.Add(this.lblSurnamePs);
            this.gbxPassengerCard.Controls.Add(this.lblNamePs);
            this.gbxPassengerCard.Controls.Add(this.pbxPassengerImage);
            this.gbxPassengerCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbxPassengerCard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxPassengerCard.Location = new System.Drawing.Point(422, 143);
            this.gbxPassengerCard.Name = "gbxPassengerCard";
            this.gbxPassengerCard.Size = new System.Drawing.Size(555, 266);
            this.gbxPassengerCard.TabIndex = 3;
            this.gbxPassengerCard.TabStop = false;
            this.gbxPassengerCard.Text = "Sərnişin Məlumat Paneli";
            // 
            // lblTurnedGender
            // 
            this.lblTurnedGender.AutoSize = true;
            this.lblTurnedGender.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedGender.Location = new System.Drawing.Point(231, 165);
            this.lblTurnedGender.Name = "lblTurnedGender";
            this.lblTurnedGender.Size = new System.Drawing.Size(58, 21);
            this.lblTurnedGender.TabIndex = 12;
            this.lblTurnedGender.Text = "____";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(123, 167);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(94, 21);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "Cinsi :";
            // 
            // lblTurnedAge
            // 
            this.lblTurnedAge.AutoSize = true;
            this.lblTurnedAge.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedAge.Location = new System.Drawing.Point(231, 140);
            this.lblTurnedAge.Name = "lblTurnedAge";
            this.lblTurnedAge.Size = new System.Drawing.Size(58, 21);
            this.lblTurnedAge.TabIndex = 9;
            this.lblTurnedAge.Text = "____";
            // 
            // lblTurnedNationality
            // 
            this.lblTurnedNationality.AutoSize = true;
            this.lblTurnedNationality.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedNationality.Location = new System.Drawing.Point(231, 115);
            this.lblTurnedNationality.Name = "lblTurnedNationality";
            this.lblTurnedNationality.Size = new System.Drawing.Size(58, 21);
            this.lblTurnedNationality.TabIndex = 8;
            this.lblTurnedNationality.Text = "____";
            // 
            // lblTurnedSurname
            // 
            this.lblTurnedSurname.AutoSize = true;
            this.lblTurnedSurname.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedSurname.Location = new System.Drawing.Point(231, 92);
            this.lblTurnedSurname.Name = "lblTurnedSurname";
            this.lblTurnedSurname.Size = new System.Drawing.Size(58, 21);
            this.lblTurnedSurname.TabIndex = 7;
            this.lblTurnedSurname.Text = "____";
            // 
            // lblTurnedName
            // 
            this.lblTurnedName.AutoSize = true;
            this.lblTurnedName.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurnedName.Location = new System.Drawing.Point(231, 69);
            this.lblTurnedName.Name = "lblTurnedName";
            this.lblTurnedName.Size = new System.Drawing.Size(58, 21);
            this.lblTurnedName.TabIndex = 6;
            this.lblTurnedName.Text = "____";
            // 
            // lblAgePs
            // 
            this.lblAgePs.AutoSize = true;
            this.lblAgePs.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgePs.Location = new System.Drawing.Point(135, 142);
            this.lblAgePs.Name = "lblAgePs";
            this.lblAgePs.Size = new System.Drawing.Size(82, 21);
            this.lblAgePs.TabIndex = 4;
            this.lblAgePs.Text = "Yaşı :";
            // 
            // lblNationalityPS
            // 
            this.lblNationalityPS.AutoSize = true;
            this.lblNationalityPS.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNationalityPS.Location = new System.Drawing.Point(75, 117);
            this.lblNationalityPS.Name = "lblNationalityPS";
            this.lblNationalityPS.Size = new System.Drawing.Size(142, 21);
            this.lblNationalityPS.TabIndex = 3;
            this.lblNationalityPS.Text = "Milliyəti :";
            // 
            // lblSurnamePs
            // 
            this.lblSurnamePs.AutoSize = true;
            this.lblSurnamePs.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurnamePs.Location = new System.Drawing.Point(111, 94);
            this.lblSurnamePs.Name = "lblSurnamePs";
            this.lblSurnamePs.Size = new System.Drawing.Size(106, 21);
            this.lblSurnamePs.TabIndex = 2;
            this.lblSurnamePs.Text = "Soyadı :";
            // 
            // lblNamePs
            // 
            this.lblNamePs.AutoSize = true;
            this.lblNamePs.Font = new System.Drawing.Font("MS Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNamePs.Location = new System.Drawing.Point(147, 71);
            this.lblNamePs.Name = "lblNamePs";
            this.lblNamePs.Size = new System.Drawing.Size(70, 21);
            this.lblNamePs.TabIndex = 1;
            this.lblNamePs.Text = "Adı :";
            // 
            // btnCheckUserExist
            // 
            this.btnCheckUserExist.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCheckUserExist.BackgroundImage")));
            this.btnCheckUserExist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCheckUserExist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckUserExist.Font = new System.Drawing.Font("MS Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCheckUserExist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCheckUserExist.Location = new System.Drawing.Point(744, 76);
            this.btnCheckUserExist.Name = "btnCheckUserExist";
            this.btnCheckUserExist.Size = new System.Drawing.Size(233, 61);
            this.btnCheckUserExist.TabIndex = 4;
            this.btnCheckUserExist.Text = "Məlumatları Yoxla";
            this.btnCheckUserExist.UseVisualStyleBackColor = true;
            this.btnCheckUserExist.Click += new System.EventHandler(this.btnCheckUserExist_Click);
            // 
            // rbtnIsChecked
            // 
            this.rbtnIsChecked.AutoSize = true;
            this.rbtnIsChecked.BackColor = System.Drawing.Color.Lavender;
            this.rbtnIsChecked.Cursor = System.Windows.Forms.Cursors.No;
            this.rbtnIsChecked.Enabled = false;
            this.rbtnIsChecked.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtnIsChecked.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rbtnIsChecked.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.rbtnIsChecked.Location = new System.Drawing.Point(486, 91);
            this.rbtnIsChecked.Name = "rbtnIsChecked";
            this.rbtnIsChecked.Size = new System.Drawing.Size(199, 28);
            this.rbtnIsChecked.TabIndex = 5;
            this.rbtnIsChecked.TabStop = true;
            this.rbtnIsChecked.Text = "YOXLANILMAYIB";
            this.rbtnIsChecked.UseVisualStyleBackColor = false;
            // 
            // cmbxToTheCity
            // 
            this.cmbxToTheCity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbxToTheCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.cmbxToTheCity.FormattingEnabled = true;
            this.cmbxToTheCity.Location = new System.Drawing.Point(408, 46);
            this.cmbxToTheCity.Name = "cmbxToTheCity";
            this.cmbxToTheCity.Size = new System.Drawing.Size(121, 24);
            this.cmbxToTheCity.TabIndex = 6;
            // 
            // gbxAirTraectory
            // 
            this.gbxAirTraectory.BackColor = System.Drawing.SystemColors.Highlight;
            this.gbxAirTraectory.Controls.Add(this.lblTurnedFromCity);
            this.gbxAirTraectory.Controls.Add(this.btnFinalChecker);
            this.gbxAirTraectory.Controls.Add(this.lblToCity);
            this.gbxAirTraectory.Controls.Add(this.lblFromCity);
            this.gbxAirTraectory.Controls.Add(this.cmbxToTheCity);
            this.gbxAirTraectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.gbxAirTraectory.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxAirTraectory.Location = new System.Drawing.Point(422, 439);
            this.gbxAirTraectory.Name = "gbxAirTraectory";
            this.gbxAirTraectory.Size = new System.Drawing.Size(555, 155);
            this.gbxAirTraectory.TabIndex = 7;
            this.gbxAirTraectory.TabStop = false;
            this.gbxAirTraectory.Text = "SƏYAHƏT MARŞRUTU";
            // 
            // lblTurnedFromCity
            // 
            this.lblTurnedFromCity.AutoSize = true;
            this.lblTurnedFromCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblTurnedFromCity.Location = new System.Drawing.Point(157, 49);
            this.lblTurnedFromCity.Name = "lblTurnedFromCity";
            this.lblTurnedFromCity.Size = new System.Drawing.Size(125, 17);
            this.lblTurnedFromCity.TabIndex = 10;
            this.lblTurnedFromCity.Text = "_____________";
            // 
            // btnFinalChecker
            // 
            this.btnFinalChecker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFinalChecker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalChecker.Font = new System.Drawing.Font("Bernard MT Condensed", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalChecker.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnFinalChecker.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalChecker.Image")));
            this.btnFinalChecker.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinalChecker.Location = new System.Drawing.Point(297, 86);
            this.btnFinalChecker.Name = "btnFinalChecker";
            this.btnFinalChecker.Size = new System.Drawing.Size(231, 52);
            this.btnFinalChecker.TabIndex = 9;
            this.btnFinalChecker.Text = "DÜZGÜNLÜYÜ  YOXLA";
            this.btnFinalChecker.UseVisualStyleBackColor = true;
            this.btnFinalChecker.Click += new System.EventHandler(this.btnFinalChecker_Click);
            // 
            // lblToCity
            // 
            this.lblToCity.AutoSize = true;
            this.lblToCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblToCity.Location = new System.Drawing.Point(297, 49);
            this.lblToCity.Name = "lblToCity";
            this.lblToCity.Size = new System.Drawing.Size(92, 17);
            this.lblToCity.TabIndex = 8;
            this.lblToCity.Text = "Bu Ölkəyə :";
            // 
            // lblFromCity
            // 
            this.lblFromCity.AutoSize = true;
            this.lblFromCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblFromCity.Location = new System.Drawing.Point(29, 49);
            this.lblFromCity.Name = "lblFromCity";
            this.lblFromCity.Size = new System.Drawing.Size(102, 17);
            this.lblFromCity.TabIndex = 7;
            this.lblFromCity.Text = "Bu Ölkədən :";
            // 
            // pcbSuccess
            // 
            this.pcbSuccess.Image = ((System.Drawing.Image)(resources.GetObject("pcbSuccess.Image")));
            this.pcbSuccess.Location = new System.Drawing.Point(12, 143);
            this.pcbSuccess.Name = "pcbSuccess";
            this.pcbSuccess.Size = new System.Drawing.Size(385, 266);
            this.pcbSuccess.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSuccess.TabIndex = 13;
            this.pcbSuccess.TabStop = false;
            this.pcbSuccess.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btnClear.Location = new System.Drawing.Point(12, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(105, 80);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "TEMIZLE";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormWorkPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(999, 631);
            this.Controls.Add(this.pcbSuccess);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbxAirTraectory);
            this.Controls.Add(this.rbtnIsChecked);
            this.Controls.Add(this.btnCheckUserExist);
            this.Controls.Add(this.gbxPassengerCard);
            this.Controls.Add(this.lbIUserSecureNumber);
            this.Controls.Add(this.tbxUserSecureNumber);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormWorkPanel";
            this.Text = "EMELIYYAT PANELI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWorkPanel_FormClosing);
            this.Load += new System.EventHandler(this.FormWorkPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxPassengerImage)).EndInit();
            this.gbxPassengerCard.ResumeLayout(false);
            this.gbxPassengerCard.PerformLayout();
            this.gbxAirTraectory.ResumeLayout(false);
            this.gbxAirTraectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSuccess)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxPassengerImage;
        private System.Windows.Forms.TextBox tbxUserSecureNumber;
        private System.Windows.Forms.Label lbIUserSecureNumber;
        private System.Windows.Forms.GroupBox gbxPassengerCard;
        private System.Windows.Forms.Button btnCheckUserExist;
        private System.Windows.Forms.RadioButton rbtnIsChecked;
        private System.Windows.Forms.Label lblNationalityPS;
        private System.Windows.Forms.Label lblSurnamePs;
        private System.Windows.Forms.Label lblNamePs;
        private System.Windows.Forms.Label lblAgePs;
        private System.Windows.Forms.Label lblTurnedAge;
        private System.Windows.Forms.Label lblTurnedNationality;
        private System.Windows.Forms.Label lblTurnedSurname;
        private System.Windows.Forms.Label lblTurnedName;
        private System.Windows.Forms.ComboBox cmbxToTheCity;
        private System.Windows.Forms.GroupBox gbxAirTraectory;
        private System.Windows.Forms.Button btnFinalChecker;
        private System.Windows.Forms.Label lblToCity;
        private System.Windows.Forms.Label lblFromCity;
        private System.Windows.Forms.Label lblTurnedFromCity;
        private System.Windows.Forms.Label lblTurnedGender;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.PictureBox pcbSuccess;
        private System.Windows.Forms.Button btnClear;
    }
}