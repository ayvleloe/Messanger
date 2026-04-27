using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Messanger
{
    public static class EMailKlasse
    {
        public static string tempUsername;
        public static string tempEmail;
        public static string tempPassword;

        static string aktuellerCode;
        static Random rnd = new Random();

        public static string GeneriereCode()
        {
            aktuellerCode = rnd.Next(100000, 999999).ToString();
            return aktuellerCode;
        }

        public static Task SendeCode(string empfaengerEmail)
        {
            GeneriereCode();

            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("MyGmailgmail.com", "app password"), // HIER GMAIL AND APP PASSWORD EINGEBEN
                EnableSsl = true
            };

            MailMessage mail = new MailMessage();
            mail.From = new MailAddress("MyGmail@gmail.com"); // HIER GMAIL EINGEBEN
            mail.To.Add(empfaengerEmail);
            mail.Subject = "Dein Bestätigungscode";
            mail.Body = $"{tempUsername}, Dein Code ist: {aktuellerCode}";

            MessageBox.Show(aktuellerCode);

            client.Send(mail);

            return Task.CompletedTask;
        }

        public static void PruefungEMail(string eingegebenenCode)
        {
            if (aktuellerCode == eingegebenenCode) {
                byte[] hash = PasswordHashing.HashPasswordArgon2id(tempPassword, out byte[] salt);

                AccountsKlasse newUser = new AccountsKlasse
                {
                    Username = tempUsername,
                    EMail = tempEmail,
                    PasswordHash = hash,
                    PasswordSalt = salt
                };

                AccountsEigenschaften.accounts.Add(newUser);
                AccountsEigenschaften.currentUser = newUser;

                WechselZuKlasse.Wechsel(Messanger.RegistrationEMailFenster, Messanger.MenuFenster);

            } else { MessageBox.Show("Code ist falsch."); }
        }

    }
}
