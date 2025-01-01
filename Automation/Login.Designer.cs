namespace Automation
{
    partial class loginScreen
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userlbl = new System.Windows.Forms.Label();
            this.sifrelbl = new System.Windows.Forms.Label();
            this.usertb = new System.Windows.Forms.TextBox();
            this.sifretb = new System.Windows.Forms.TextBox();
            this.loginSifrecheck = new System.Windows.Forms.CheckBox();
            this.loginbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Automation.Properties.Resources.Market;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(531, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.userlbl.ForeColor = System.Drawing.Color.Gray;
            this.userlbl.Location = new System.Drawing.Point(80, 261);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(158, 29);
            this.userlbl.TabIndex = 1;
            this.userlbl.Text = "Kullanıcı Adı";
            // 
            // sifrelbl
            // 
            this.sifrelbl.AutoSize = true;
            this.sifrelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifrelbl.ForeColor = System.Drawing.Color.Gray;
            this.sifrelbl.Location = new System.Drawing.Point(82, 324);
            this.sifrelbl.Name = "sifrelbl";
            this.sifrelbl.Size = new System.Drawing.Size(195, 29);
            this.sifrelbl.TabIndex = 2;
            this.sifrelbl.Text = "Kullanıcı Şifresi";
            // 
            // usertb
            // 
            this.usertb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.usertb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.usertb.Location = new System.Drawing.Point(324, 263);
            this.usertb.Name = "usertb";
            this.usertb.Size = new System.Drawing.Size(157, 27);
            this.usertb.TabIndex = 3;
            // 
            // sifretb
            // 
            this.sifretb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.sifretb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretb.Location = new System.Drawing.Point(324, 328);
            this.sifretb.Name = "sifretb";
            this.sifretb.Size = new System.Drawing.Size(157, 27);
            this.sifretb.TabIndex = 4;
            this.sifretb.UseSystemPasswordChar = true;
            this.sifretb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sifretb_KeyDown);
            // 
            // loginSifrecheck
            // 
            this.loginSifrecheck.AutoSize = true;
            this.loginSifrecheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginSifrecheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginSifrecheck.Location = new System.Drawing.Point(333, 370);
            this.loginSifrecheck.Name = "loginSifrecheck";
            this.loginSifrecheck.Size = new System.Drawing.Size(148, 24);
            this.loginSifrecheck.TabIndex = 5;
            this.loginSifrecheck.Text = "Şifreyi Göster";
            this.loginSifrecheck.UseVisualStyleBackColor = true;
            this.loginSifrecheck.CheckedChanged += new System.EventHandler(this.loginSifrecheck_CheckedChanged);
            // 
            // loginbtn
            // 
            this.loginbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginbtn.Location = new System.Drawing.Point(376, 414);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(105, 44);
            this.loginbtn.TabIndex = 0;
            this.loginbtn.Text = "Giriş Yap";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // loginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(531, 504);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.loginSifrecheck);
            this.Controls.Add(this.sifretb);
            this.Controls.Add(this.usertb);
            this.Controls.Add(this.sifrelbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Yap";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label sifrelbl;
        private System.Windows.Forms.TextBox usertb;
        private System.Windows.Forms.TextBox sifretb;
        private System.Windows.Forms.CheckBox loginSifrecheck;
        private System.Windows.Forms.Button loginbtn;
    }
}