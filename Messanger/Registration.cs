using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
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

            WechselZuKlasse.Wechsel(this, Messanger.LoginFenster);
        }

        private async void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string email = TextBoxEMail.Text.Trim();
            string password = TextBoxPassword.Text.Trim();

            if (!IstEmailGueltig(email))
            {
                MessageBox.Show("Bitte gültige E-Mail eingeben!");
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("E-Mail darf nicht leer sein!");
                return;
            }

            await RegistrationKlasse.RegistrationAnAccount(username, email, password);
        }

        bool IstEmailGueltig(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
