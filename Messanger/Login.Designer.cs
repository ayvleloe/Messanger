namespace Messanger
{
    partial class Login
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
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonPassword = new System.Windows.Forms.Button();
            this.LabelPassword = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.ButtonSignUp = new System.Windows.Forms.Button();
            this.TextBoxPasswordLogin = new System.Windows.Forms.TextBox();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonChange
            // 
            this.ButtonChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonChange.Location = new System.Drawing.Point(150, 146);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(149, 40);
            this.ButtonChange.TabIndex = 17;
            this.ButtonChange.Text = "I don’t have an account yet";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // ButtonPassword
            // 
            this.ButtonPassword.Location = new System.Drawing.Point(269, 90);
            this.ButtonPassword.Name = "ButtonPassword";
            this.ButtonPassword.Size = new System.Drawing.Size(30, 31);
            this.ButtonPassword.TabIndex = 16;
            this.ButtonPassword.UseVisualStyleBackColor = true;
            this.ButtonPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ButtonPassword_MouseDown);
            this.ButtonPassword.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ButtonPassword_MouseUp);
            // 
            // LabelPassword
            // 
            this.LabelPassword.AutoSize = true;
            this.LabelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPassword.Location = new System.Drawing.Point(0, 62);
            this.LabelPassword.Name = "LabelPassword";
            this.LabelPassword.Size = new System.Drawing.Size(106, 25);
            this.LabelPassword.TabIndex = 15;
            this.LabelPassword.Text = "Password";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.Location = new System.Drawing.Point(0, 0);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(110, 25);
            this.LabelUsername.TabIndex = 13;
            this.LabelUsername.Text = "Username";
            // 
            // ButtonSignUp
            // 
            this.ButtonSignUp.BackColor = System.Drawing.Color.Black;
            this.ButtonSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignUp.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSignUp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ButtonSignUp.Location = new System.Drawing.Point(0, 146);
            this.ButtonSignUp.Name = "ButtonSignUp";
            this.ButtonSignUp.Size = new System.Drawing.Size(144, 40);
            this.ButtonSignUp.TabIndex = 12;
            this.ButtonSignUp.Text = "Sign in";
            this.ButtonSignUp.UseVisualStyleBackColor = false;
            this.ButtonSignUp.Click += new System.EventHandler(this.ButtonSignUp_Click);
            // 
            // TextBoxPasswordLogin
            // 
            this.TextBoxPasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxPasswordLogin.Location = new System.Drawing.Point(0, 90);
            this.TextBoxPasswordLogin.Name = "TextBoxPasswordLogin";
            this.TextBoxPasswordLogin.Size = new System.Drawing.Size(299, 31);
            this.TextBoxPasswordLogin.TabIndex = 11;
            this.TextBoxPasswordLogin.UseSystemPasswordChar = true;
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxUsername.Location = new System.Drawing.Point(0, 28);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(299, 31);
            this.TextBoxUsername.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.ButtonPassword);
            this.Controls.Add(this.LabelPassword);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonSignUp);
            this.Controls.Add(this.TextBoxPasswordLogin);
            this.Controls.Add(this.TextBoxUsername);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(301, 188);
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonPassword;
        private System.Windows.Forms.Label LabelPassword;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.Button ButtonSignUp;
        private System.Windows.Forms.TextBox TextBoxPasswordLogin;
        private System.Windows.Forms.TextBox TextBoxUsername;
    }
}
