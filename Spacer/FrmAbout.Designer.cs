namespace Spacer
{
    partial class FrmAbout
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
            this.lblSpacer = new System.Windows.Forms.Label();
            this.lblCyanit = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtLicense = new System.Windows.Forms.TextBox();
            this.txtGithub = new System.Windows.Forms.TextBox();
            this.btnGithub = new System.Windows.Forms.Button();
            this.btnTwitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpacer.Location = new System.Drawing.Point(12, 9);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(127, 25);
            this.lblSpacer.TabIndex = 10;
            this.lblSpacer.Text = "Spacer v1.0";
            // 
            // lblCyanit
            // 
            this.lblCyanit.AutoSize = true;
            this.lblCyanit.Location = new System.Drawing.Point(198, 9);
            this.lblCyanit.Name = "lblCyanit";
            this.lblCyanit.Size = new System.Drawing.Size(74, 13);
            this.lblCyanit.TabIndex = 11;
            this.lblCyanit.Text = "© cyanit 2018";
            // 
            // txtAuthor
            // 
            this.txtAuthor.BackColor = System.Drawing.SystemColors.Control;
            this.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAuthor.Location = new System.Drawing.Point(12, 46);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(259, 13);
            this.txtAuthor.TabIndex = 12;
            this.txtAuthor.Text = "Author: cyanit";
            // 
            // txtLicense
            // 
            this.txtLicense.BackColor = System.Drawing.SystemColors.Control;
            this.txtLicense.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLicense.Location = new System.Drawing.Point(12, 65);
            this.txtLicense.Name = "txtLicense";
            this.txtLicense.Size = new System.Drawing.Size(259, 13);
            this.txtLicense.TabIndex = 12;
            this.txtLicense.Text = "License: MIT License, credit me!";
            // 
            // txtGithub
            // 
            this.txtGithub.BackColor = System.Drawing.SystemColors.Control;
            this.txtGithub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGithub.Location = new System.Drawing.Point(12, 84);
            this.txtGithub.Multiline = true;
            this.txtGithub.Name = "txtGithub";
            this.txtGithub.Size = new System.Drawing.Size(259, 54);
            this.txtGithub.TabIndex = 12;
            this.txtGithub.Text = "If you find a bug, just go to my github and write an bug report, I would apprecia" +
    "te that.\r\n\r\nAlso, feel free to say hi to me, im usually on twitter.";
            // 
            // btnGithub
            // 
            this.btnGithub.Location = new System.Drawing.Point(12, 149);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Size = new System.Drawing.Size(127, 23);
            this.btnGithub.TabIndex = 0;
            this.btnGithub.Text = "Github";
            this.btnGithub.UseVisualStyleBackColor = true;
            this.btnGithub.Click += new System.EventHandler(this.btnGithub_Click);
            // 
            // btnTwitter
            // 
            this.btnTwitter.Location = new System.Drawing.Point(145, 149);
            this.btnTwitter.Name = "btnTwitter";
            this.btnTwitter.Size = new System.Drawing.Size(127, 23);
            this.btnTwitter.TabIndex = 1;
            this.btnTwitter.Text = "Twitter";
            this.btnTwitter.UseVisualStyleBackColor = true;
            this.btnTwitter.Click += new System.EventHandler(this.btnTwitter_Click);
            // 
            // FrmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 184);
            this.Controls.Add(this.btnTwitter);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.txtGithub);
            this.Controls.Add(this.txtLicense);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblSpacer);
            this.Controls.Add(this.lblCyanit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.Label lblCyanit;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtLicense;
        private System.Windows.Forms.TextBox txtGithub;
        private System.Windows.Forms.Button btnGithub;
        private System.Windows.Forms.Button btnTwitter;
    }
}