using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionUI
{
    class QuietTextBox : TextBox
    {
        private const int EM_SHOWBALLOONTIP = 0x1503;

        protected override void WndProc(ref Message m)
        {
            // ----- Prevent the system-level Caps Lock message from showing up.
            if (m.Msg == EM_SHOWBALLOONTIP)
            {
                m.Result = (IntPtr)0;
                return;
            }
            base.WndProc(ref m);
        }
    }
}
