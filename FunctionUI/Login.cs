using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionUI
{
    class Login
    {
        private string _usrname;
        private string _psswrd;
        public Login()
        {
            _usrname = "user";
            _psswrd = "pass";
        }

        public bool LoginCheck(string usrname, string psswrd)
        {
            if (usrname == _usrname && psswrd == _psswrd)
            {
                return true;
            }
            return false;
        }
        ~Login()
        {
            //
        }
    }
}