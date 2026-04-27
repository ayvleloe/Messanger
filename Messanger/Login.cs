using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            WechselZuKlasse.Wechsel(this, Messanger.RegistrationFenster);
        }

        private void ButtonPassword_MouseDown(object sender, MouseEventArgs e)
        {
            TextBoxPasswordLogin.UseSystemPasswordChar = false;
        }

        private void ButtonPassword_MouseUp(object sender, MouseEventArgs e)
        {
            TextBoxPasswordLogin.UseSystemPasswordChar = true;
        }

        private void ButtonSignUp_Click(object sender, EventArgs e)
        {
            string username = TextBoxUsername.Text;
            string password = TextBoxPasswordLogin.Text;

            LoginKlasse.LoginInAccount(username, password);
        }
    }
}
