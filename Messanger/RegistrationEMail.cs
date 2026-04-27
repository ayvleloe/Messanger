using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public partial class RegistrationEMail : UserControl
    {
        public RegistrationEMail()
        {
            InitializeComponent();
        }

        static string eingegebenenCode;

        private void ButtonZurueckEMailLogin_Click(object sender, EventArgs e)
        {
            WechselZuKlasse.Wechsel(this, Messanger.RegistrationFenster);
        }

        private void RegistrationEMail_Load(object sender, EventArgs e)
        {

        }

        private void ButtonWeiterEMailLogin_Click(object sender, EventArgs e)
        {

            eingegebenenCode = TextBoxEMailLogin.Text;

            EMailKlasse.PruefungEMail(eingegebenenCode);
        }
    }
}
