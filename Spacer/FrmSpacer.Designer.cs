namespace Spacer
{
    partial class FrmSpacer
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSpacer));
            this.lblSpacer = new System.Windows.Forms.Label();
            this.btnStartSC = new System.Windows.Forms.Button();
            this.lblCyanit = new System.Windows.Forms.Label();
            this.btnDeskSC = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSpacer
            // 
            this.lblSpacer.AutoSize = true;
            this.lblSpacer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpacer.Location = new System.Drawing.Point(12, 9);
            this.lblSpacer.Name = "lblSpacer";
            this.lblSpacer.Size = new System.Drawing.Size(139, 29);
            this.lblSpacer.TabIndex = 10;
            this.lblSpacer.Text = "Spacer v1.0";
            // 
            // btnStartSC
            // 
            this.btnStartSC.Location = new System.Drawing.Point(12, 188);
            this.btnStartSC.Name = "btnStartSC";
            this.btnStartSC.Size = new System.Drawing.Size(146, 23);
            this.btnStartSC.TabIndex = 8;
            this.btnStartSC.Text = "Create Startmenu Shortcut";
            this.btnStartSC.UseVisualStyleBackColor = true;
            // 
            // lblCyanit
            // 
            this.lblCyanit.AutoSize = true;
            this.lblCyanit.Location = new System.Drawing.Point(261, 9);
            this.lblCyanit.Name = "lblCyanit";
            this.lblCyanit.Size = new System.Drawing.Size(49, 13);
            this.lblCyanit.TabIndex = 11;
            this.lblCyanit.Text = "by cyanit";
            this.lblCyanit.Click += new System.EventHandler(this.labelCyanit_Click);
            // 
            // btnDeskSC
            // 
            this.btnDeskSC.Location = new System.Drawing.Point(164, 188);
            this.btnDeskSC.Name = "btnDeskSC";
            this.btnDeskSC.Size = new System.Drawing.Size(146, 23);
            this.btnDeskSC.TabIndex = 9;
            this.btnDeskSC.Text = "Create Desktop Shortcut";
            this.btnDeskSC.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(12, 51);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 109);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // FrmSpacer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 181);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCyanit);
            this.Controls.Add(this.btnDeskSC);
            this.Controls.Add(this.btnStartSC);
            this.Controls.Add(this.lblSpacer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSpacer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spacer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSpacer;
        private System.Windows.Forms.Button btnStartSC;
        private System.Windows.Forms.Label lblCyanit;
        private System.Windows.Forms.Button btnDeskSC;
        private System.Windows.Forms.TextBox textBox1;
    }
}

