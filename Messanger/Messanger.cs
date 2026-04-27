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

        public Messanger()
        {
            InitializeComponent();

            OpenAnyFenster(LoginFenster);
            OpenAnyFenster(RegistrationEMailFenster);
            OpenAnyFenster(RegistrationFenster);
            OpenAnyFenster(MenuFenster);

            this.Controls.Add(RegistrationEMailFenster);
            this.Controls.Add(MenuFenster);
            this.Controls.Add(LoginFenster);
            this.Controls.Add(RegistrationFenster);

            MenuFenster.Visible = false;
            RegistrationEMailFenster.Visible = false;
            LoginFenster.Visible = false;

        }

        public static Login LoginFenster = new Login();
        public static Registration RegistrationFenster = new Registration();
        public static RegistrationEMail RegistrationEMailFenster = new RegistrationEMail();
        public static Menu MenuFenster = new Menu();

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
