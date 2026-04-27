using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Messanger
{
    public static class WechselZuKlasse
    {
        public static void Wechsel(UserControl current, UserControl next)
        {
            current.Visible = false;
            next.Visible = true;
        }
    }

    
}
