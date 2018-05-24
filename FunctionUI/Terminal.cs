using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunctionUI
{
    public partial class Terminal : Form
    {
        public Terminal()
        {
            InitializeComponent();
            txt_terminal.BackColor = Color.Black;
            txt_terminal.ForeColor = Color.GhostWhite;
            txt_terminal.Font = new Font("Consolas", 10);
        }

        public void Input()
        {
            txt_terminal.Text += "OS/>> ";
        }

        public void RunCommand()
        {
            string command = txt_terminal.Text;
        }

        public string CommandOutput()
        {
            return "TESTING";
        }
    }
}
