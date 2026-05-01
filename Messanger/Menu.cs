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
    public partial class Menu : UserControl
    {
        public Menu()
        {
            InitializeComponent();
            FlowLayoutPanelChats.AutoScroll = true;
        }

        public void Addmenuchat(string benutzername)
        {
            FensterChat chat = new FensterChat();
            chat.SetButtonText(benutzername);
            FlowLayoutPanelChats.Controls.Add(chat);
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSendenMenu_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSuchNachBenutzer_Click(object sender, EventArgs e)
        {

            SuchNachBenutzer.SuchNachBenutzerFunktion(
                TextBoxSuchNachBenutzer.Text, this);
        }
    }
}
