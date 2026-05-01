using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public static class SuchNachBenutzer
    {
        public static void SuchNachBenutzerFunktion(string benutzername, Menu menu)
        { 
            bool existiert = AccountsEigenschaften.accounts.Any(u => u.Username == benutzername);

            if (existiert)
            {
                if (benutzername == AccountsEigenschaften.currentUser.Username)
                {
                    MessageBox.Show("Du kannst nicht mit dir selbst chatten.");
                    return;
                }

                menu.Addmenuchat(benutzername);
            }
            else
            {
                MessageBox.Show("Benutzer nicht gefunden.");
            }
        }
    }
}