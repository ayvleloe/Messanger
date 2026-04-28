namespace Messanger
{
    partial class Registration
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
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.TextBoxEMail = new System.Windows.Forms.TextBox();
            this.TextBoxPassword = new System.Windows.Forms.TextBox();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.LabelEMail = new System.Windows.Forms.Label();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.ButtonPassword = new System.Windows.Forms.Button();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(3, 29);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(299, 31);
            this.TextBoxUsername.TabIndex = 0;
            // 
            // TextBoxEMail
            // 
            this.TextBoxEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEMail.Location = new System.Drawing.Point(3, 92);
            this.TextBoxEMail.Name = "TextBoxEMail";
            this.TextBoxEMail.Size = new System.Drawing.Size(299, 31);
            this.TextBoxEMail.TabIndex = 1;
            this.TextBoxEMail.Text = "@gmail.com";
            // 
            // TextBoxPassword
            // 
            this.TextBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPassword.Location = new System.Drawing.Point(3, 154);
            this.TextBoxPassword.Name = "TextBoxPassword";
            this.TextBoxPassword.Size = new System.Drawing.Size(299, 31);
            this.TextBoxPassword.TabIndex = 2;
            this.TextBoxPassword.UseSystemPasswordChar = true;
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.Black;
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSignUp.Location = new System.Drawing.Point(3, 210);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(144, 40);
            this.ButtonSignUp.TabIndex = 3;
            this.ButtonSignUp.Text = "Sign up";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(3, 1);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(110, 25);
            this.LabelUsername.TabIndex = 4;
            this.LabelUsername.Text = "Username";
            // 
            // LabelEMail
            // 
            this.LabelEMail.AutoSize = true;
            this.LabelEMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEMail.Location = new System.Drawing.Point(3, 64);
            this.LabelEMail.Name = "LabelEMail";
            this.LabelEMail.Size = new System.Drawing.Size(144, 25);
            this.LabelEMail.TabIndex = 5;
            this.LabelEMail.Text = "E-Mail adress";
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(3, 126);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(106, 25);
            this.LabelPassword.TabIndex = 6;
            this.LabelPassword.Text = "Password";
            // 
            // ButtonPassword
            // 
            this.ButtonPassword.Location = new System.Drawing.Point(272, 154);
            this.ButtonPassword.Name = "ButtonPassword";
            this.ButtonPassword.Size = new System.Drawing.Size(30, 31);
            this.ButtonPassword.TabIndex = 7;
            this.ButtonPassword.Text = "X";
            this.ButtonPassword.UseVisualStyleBackColor = true;
            this.ButtonPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPassword_MouseDown);
            this.ButtonPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPassword_MouseUp);
            // 
            // ButtonChange
            // 
            this.ButtonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChange.Location = new System.Drawing.Point(153, 210);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(149, 40);
            this.ButtonChange.TabIndex = 8;
            this.ButtonChange.Text = "I already have an account";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click_1);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.ButtonPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelEMail);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.TextBoxPassword);
            this.Controls.Add(this.TextBoxEMail);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "Registration";
            this.Size = new System.Drawing.Size(304, 252);
            this.Load += new System.EventHandler(this.Registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.TextBox TextBoxEMail;
        private System.Windows.Forms.TextBox TextBoxPassword;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Label LabelEMail;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Button ButtonPassword;
        private System.Windows.Forms.Button ButtonChange;
    }
}
