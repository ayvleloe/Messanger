using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;
using System.Net.Mail;

namespace Messanger
{
    public static class RegistrationKlasse
    {
        public static async Task RegistrationAnAccount(string username, string email, string password)
        {
            bool existiertUsername = AccountsEigenschaften.accounts.Any(u => u.Username == username);
            bool existiertEMail = AccountsEigenschaften.accounts.Any(u => u.EMail == email);

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
                    EMailKlasse.tempUsername = username;
                    EMailKlasse.tempEmail = email;
                    EMailKlasse.tempPassword = password;

                    try
                    {
                        await EMailKlasse.SendeCode(email);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    WechselZuKlasse.Wechsel(Messanger.RegistrationFenster, Messanger.RegistrationEMailFenster);
                }
            }
        }
    }
}
