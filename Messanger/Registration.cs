using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public partial class Registration : UserControl
    {
        public Registration()
        {
            InitializeComponent();
        }

        public event EventHandler WechselZuLogin;
        public event EventHandler WechselZuRegistrationEmail;

        public List<Accounts> accountsListRegistration { get; set; }
        public Accounts currentUserRegistration { get; set; }

        RegistrationEMail RegistrationEmailFenster;

        void RegistrationAnAccount()
        {
            string username = TextBoxUsername.Text;
            string email = TextBoxEMail.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            bool existiertUsername = accountsListRegistration.Any(u => u.Username == username);
            bool existiertEMail = accountsListRegistration.Any(u => u.EMail == email);

            if (existiertUsername || existiertEMail)
            {
                MessageBox.Show("Solche Username oder E-Mail existiert schon.");
            }
            else
            {
                if (username.Length < 3 || password.Length < 8 || username.Length > 32 || password.Length > 32)
                {
                    MessageBox.Show("Error:" + Environment.NewLine + "" + Environment.NewLine +
                    "Username muss länger als 3 Symbolen und nicht länger als 32 Symbolen sein" + Environment.NewLine +
                     "Password muss länger als 8 Symbolen und nicht länger als 32 Symbolen sein");
                }
                else
                {
                    byte[] hash = PasswordHashing.HashPasswordArgon2id(password, out byte[] salt);
                    WechselZuRegistrationEmail?.Invoke(this, EventArgs.Empty);


                    /*Accounts newUser = new Accounts
                    {
                        Username = username,
                        EMail = email,
                        PasswordHash = hash,
                        PasswordSalt = salt
                    };

                    accountsListRegistration.Add(newUser); // PERENOS NA EMAIL
                    currentUserRegistration = newUser; */
                }
            }
        }


        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void ButtonPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = true;
        }

        private void ButtonPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxPassword.UseSystemPasswordChar = false;
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {

        }

        private void ButtonChange_Click_1(object sender, EventArgs e)
        {
            WechselZuLogin?.Invoke(this, EventArgs.Empty);
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            RegistrationAnAccount();
        }
    }
}
