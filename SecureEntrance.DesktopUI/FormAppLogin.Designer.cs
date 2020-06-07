namespace SecureEntrance.DesktopUI
{
    partial class FormAppLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAppLogin));
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnSign = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblUsername.ForeColor = System.Drawing.Color.Aqua;
            this.lblUsername.Location = new System.Drawing.Point(56, 46);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(165, 25);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Agent ID Nömrəsi";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.MidnightBlue;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblPassword.ForeColor = System.Drawing.Color.Aqua;
            this.lblPassword.Location = new System.Drawing.Point(98, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(123, 25);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Agent Şifrəsi";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxUsername.Location = new System.Drawing.Point(273, 51);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(213, 24);
            this.tbxUsername.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.tbxPassword.Location = new System.Drawing.Point(273, 87);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(213, 24);
            this.tbxPassword.TabIndex = 3;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxPassword_TextChanged);
            // 
            // btnSign
            // 
            this.btnSign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSign.Image = ((System.Drawing.Image)(resources.GetObject("btnSign.Image")));
            this.btnSign.Location = new System.Drawing.Point(510, 51);
            this.btnSign.Name = "btnSign";
            this.btnSign.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.btnSign.Size = new System.Drawing.Size(135, 189);
            this.btnSign.TabIndex = 4;
            this.btnSign.Text = "DAXİL OL";
            this.btnSign.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSign.UseVisualStyleBackColor = true;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.ForeColor = System.Drawing.Color.Chartreuse;
            this.button1.Location = new System.Drawing.Point(510, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "GERI QAYIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAppLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(659, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAppLogin";
            this.Text = "AGENT-GIRIS PANELI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAppLogin_FormClosing);
            this.Load += new System.EventHandler(this.FormAppLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button button1;
    }
}

