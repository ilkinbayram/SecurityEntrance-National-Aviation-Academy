namespace SecureEntrance.DesktopUI
{
    partial class FormMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMessage));
            this.pcbError1 = new System.Windows.Forms.PictureBox();
            this.pcbError2 = new System.Windows.Forms.PictureBox();
            this.lblInfoError = new System.Windows.Forms.Label();
            this.btnLookInfo = new System.Windows.Forms.Button();
            this.btnBackToWork = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbError1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbError2)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbError1
            // 
            this.pcbError1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbError1.BackgroundImage")));
            this.pcbError1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbError1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pcbError1.ErrorImage")));
            this.pcbError1.Location = new System.Drawing.Point(286, 359);
            this.pcbError1.Name = "pcbError1";
            this.pcbError1.Size = new System.Drawing.Size(196, 120);
            this.pcbError1.TabIndex = 0;
            this.pcbError1.TabStop = false;
            // 
            // pcbError2
            // 
            this.pcbError2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbError2.Image = ((System.Drawing.Image)(resources.GetObject("pcbError2.Image")));
            this.pcbError2.Location = new System.Drawing.Point(480, 359);
            this.pcbError2.Name = "pcbError2";
            this.pcbError2.Size = new System.Drawing.Size(222, 120);
            this.pcbError2.TabIndex = 1;
            this.pcbError2.TabStop = false;
            // 
            // lblInfoError
            // 
            this.lblInfoError.AutoSize = true;
            this.lblInfoError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblInfoError.ForeColor = System.Drawing.Color.Red;
            this.lblInfoError.Location = new System.Drawing.Point(54, 24);
            this.lblInfoError.Name = "lblInfoError";
            this.lblInfoError.Size = new System.Drawing.Size(897, 26);
            this.lblInfoError.TabIndex = 2;
            this.lblInfoError.Text = "Bu Istifadecinin Movcud Lokasiya Bilgileri Ile Pasport Lokasiya Bilgileri Ortusmu" +
    "r !!!";
            // 
            // btnLookInfo
            // 
            this.btnLookInfo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnLookInfo.ForeColor = System.Drawing.Color.Aqua;
            this.btnLookInfo.Location = new System.Drawing.Point(406, 75);
            this.btnLookInfo.Name = "btnLookInfo";
            this.btnLookInfo.Size = new System.Drawing.Size(207, 65);
            this.btnLookInfo.TabIndex = 3;
            this.btnLookInfo.Text = "Melumatlari Goruntule";
            this.btnLookInfo.UseVisualStyleBackColor = false;
            this.btnLookInfo.Click += new System.EventHandler(this.btnLookInfo_Click);
            // 
            // btnBackToWork
            // 
            this.btnBackToWork.BackColor = System.Drawing.Color.Olive;
            this.btnBackToWork.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnBackToWork.ForeColor = System.Drawing.Color.Aqua;
            this.btnBackToWork.Location = new System.Drawing.Point(407, 146);
            this.btnBackToWork.Name = "btnBackToWork";
            this.btnBackToWork.Size = new System.Drawing.Size(206, 46);
            this.btnBackToWork.TabIndex = 4;
            this.btnBackToWork.Text = "Geri Qayit";
            this.btnBackToWork.UseVisualStyleBackColor = false;
            this.btnBackToWork.Click += new System.EventHandler(this.btnBackToWork_Click);
            // 
            // FormMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(989, 491);
            this.Controls.Add(this.btnBackToWork);
            this.Controls.Add(this.btnLookInfo);
            this.Controls.Add(this.lblInfoError);
            this.Controls.Add(this.pcbError2);
            this.Controls.Add(this.pcbError1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMessage";
            this.Text = "BILDIRIS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMessage_FormClosing);
            this.Load += new System.EventHandler(this.FormMessage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbError1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbError2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbError1;
        private System.Windows.Forms.PictureBox pcbError2;
        private System.Windows.Forms.Label lblInfoError;
        private System.Windows.Forms.Button btnLookInfo;
        private System.Windows.Forms.Button btnBackToWork;
    }
}