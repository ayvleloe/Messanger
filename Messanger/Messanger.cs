using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public partial class Messanger : Form
    {

        List<Accounts> accounts = new List<Accounts>();
        Accounts currentUser;
        public Messanger()
        {
            InitializeComponent();

            OpenAnyFenster(LoginFenster);
            OpenAnyFenster(RegistrationEMailFenster);
            OpenAnyFenster(RegistrationFenster);
            OpenAnyFenster(MenuFenster);

            RegistrationFenster.accountsListRegistration = accounts;
            RegistrationFenster.currentUserRegistration = currentUser;
            LoginFenster.accountsListLogin = accounts;
            LoginFenster.currentUserLogin = currentUser;

            this.Controls.Add(RegistrationEMailFenster);
            this.Controls.Add(MenuFenster);
            this.Controls.Add(LoginFenster);
            this.Controls.Add(RegistrationFenster);

            MenuFenster.Visible = false;
            RegistrationEMailFenster.Visible = false;
            LoginFenster.Visible = false;

            LoginFenster.WechselZuRegistration += (s, e) =>
            {
                LoginFenster.Visible = false;
                RegistrationFenster.Visible = true;
            };

            RegistrationFenster.WechselZuLogin += (s, e) =>
            {
                LoginFenster.Visible = true;
                RegistrationFenster.Visible = false;
            };

            RegistrationFenster.WechselZuRegistrationEmail += (s, e) =>
            {
                RegistrationFenster.Visible = false;
                RegistrationEMailFenster.Visible = true;
            };

        }

        Registration RegistrationFenster = new Registration();
        RegistrationEMail RegistrationEMailFenster = new RegistrationEMail();
        Login LoginFenster = new Login();
        Menu MenuFenster = new Menu();

       


        private void Form1_Load(object sender, EventArgs e)
        {

        }


        void OpenAnyFenster(UserControl fenster)
        {
            fenster.Anchor = AnchorStyles.None;
            fenster.Location = new Point(
                (this.ClientSize.Width - fenster.Width) / 2,
                (this.ClientSize.Height - fenster.Height) / 2
            );
        }


    }
}
