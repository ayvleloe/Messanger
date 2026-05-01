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
    public partial class FensterChat : UserControl
    {
        public FensterChat()
        {
            InitializeComponent();
        }

        public void SetButtonText(string benutzername)
        {
            button1.Text = benutzername;
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
