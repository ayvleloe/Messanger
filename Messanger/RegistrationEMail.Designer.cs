namespace Messanger
{
    partial class RegistrationEMail
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonZurueckEMailLogin = new System.Windows.Forms.Button();
            this.LabelEMail = new System.Windows.Forms.Label();
            this.TextBoxEMailLogin = new System.Windows.Forms.TextBox();
            this.ButtonWeiterEMailLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonZurueckEMailLogin
            // 
            this.ButtonZurueckEMailLogin.Location = new System.Drawing.Point(116, 130);
            this.ButtonZurueckEMailLogin.Name = "ButtonZurueckEMailLogin";
            this.ButtonZurueckEMailLogin.Size = new System.Drawing.Size(136, 27);
            this.ButtonZurueckEMailLogin.TabIndex = 7;
            this.ButtonZurueckEMailLogin.Text = "Zurück zum Einloggen";
            this.ButtonZurueckEMailLogin.UseVisualStyleBackColor = true;
            this.ButtonZurueckEMailLogin.Click += new System.EventHandler(this.ButtonZurueckEMailLogin_Click);
            // 
            // LabelEMail
            // 
            this.LabelEMail.AutoSize = true;
            this.LabelEMail.Location = new System.Drawing.Point(1, 1);
            this.LabelEMail.Name = "LabelEMail";
            this.LabelEMail.Size = new System.Drawing.Size(369, 13);
            this.LabelEMail.TabIndex = 6;
            this.LabelEMail.Text = "Zum Einloggen geben Sie den an Ihre E-Mail-Adresse  gesendeten Code ein.";
            // 
            // TextBoxEMailLogin
            // 
            this.TextBoxEMailLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.TextBoxEMailLogin.Location = new System.Drawing.Point(53, 35);
            this.TextBoxEMailLogin.Name = "TextBoxEMailLogin";
            this.TextBoxEMailLogin.Size = new System.Drawing.Size(219, 31);
            this.TextBoxEMailLogin.TabIndex = 5;
            // 
            // ButtonWeiterEMailLogin
            // 
            this.ButtonWeiterEMailLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonWeiterEMailLogin.Location = new System.Drawing.Point(278, 35);
            this.ButtonWeiterEMailLogin.Name = "ButtonWeiterEMailLogin";
            this.ButtonWeiterEMailLogin.Size = new System.Drawing.Size(50, 31);
            this.ButtonWeiterEMailLogin.TabIndex = 4;
            this.ButtonWeiterEMailLogin.Text = "Weiter";
            this.ButtonWeiterEMailLogin.UseVisualStyleBackColor = true;
            // 
            // RegistrationEMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonZurueckEMailLogin);
            this.Controls.Add(this.LabelEMail);
            this.Controls.Add(this.TextBoxEMailLogin);
            this.Controls.Add(this.ButtonWeiterEMailLogin);
            this.Name = "RegistrationEMail";
            this.Size = new System.Drawing.Size(367, 157);
            this.Load += new System.EventHandler(this.RegistrationEMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonZurueckEMailLogin;
        private System.Windows.Forms.Label LabelEMail;
        private System.Windows.Forms.TextBox TextBoxEMailLogin;
        private System.Windows.Forms.Button ButtonWeiterEMailLogin;
    }
}
