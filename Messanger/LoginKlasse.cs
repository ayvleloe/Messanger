using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public static class LoginKlasse
    {
        public static void LoginInAccount(string username, string password)
        {

            AccountsKlasse user = AccountsEigenschaften.accounts.FirstOrDefault(u => u.Username == username);

            if (user == null)
            {
                MessageBox.Show("Falscher Username oder Password");
                return;
            }

            bool passwordOk = PasswordHashing.VerifyPasswordArgon2id(password, user.PasswordSalt, user.PasswordHash);

            if (!passwordOk)
            {
                MessageBox.Show("Falscher Username oder Password");
            }
            else
            {
                AccountsEigenschaften.currentUser = user;
            }

        }
    }
}
