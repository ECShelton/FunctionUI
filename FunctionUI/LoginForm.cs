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
    public partial class LoginForm : Form
    {
        private Login _login;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            _login = new Login();
            if (_login.LoginCheck(txt_usrname.Text, txt_psswd.Text))
            {
                //do stuff
            }
            else
            {
                lbl_err.Text = "Username or Password Incorrect";
            }
        }

        private void btn_Guest_Click(object sender, EventArgs e)
        {
            this.Hide();
            Terminal _terminal = new Terminal();
            _terminal.ShowDialog();
            this.Show();
        }

        private void txt_psswd_Enter(object sender, EventArgs e)
        {
            if (txt_psswd.Text == "password")
            {
                txt_psswd.Text = null;
                txt_psswd.UseSystemPasswordChar = true;
            }
        }

        private void txt_psswd_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_psswd.Text))
            {
                txt_psswd.Text = "password";
                txt_psswd.UseSystemPasswordChar = false;
            }
        }

        private void txt_usrname_Enter(object sender, EventArgs e)
        {
            if (txt_usrname.Text == "username")
            {
                txt_usrname.Text = null;
            }
        }

        private void txt_usrname_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_usrname.Text))
            {
                txt_usrname.Text = "username";
            }
        }

        private void txt_usrname_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_err.Text = "CAPS LOCK is ON";
            }
            else
            {
                lbl_err.Text = null;
            }
        }

        private void txt_usrname_Caps(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_err.Text = "CAPS LOCK is ON";
            }
            else
            {
                lbl_err.Text = null;
            }
        }

        private void txt_psswd_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_err.Text = "CAPS LOCK is ON";
            }
            else
            {
                lbl_err.Text = null;
            }
        }
        private void txt_psswd_Caps(object sender, EventArgs e)
        {
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                lbl_err.Text = "CAPS LOCK is ON";
            }
            else
            {
                lbl_err.Text = null;
            }
        }
    }
}
