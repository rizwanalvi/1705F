using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebHRM.Models
{
    public class Login
    {
        private int _ID;

        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }
        private String _UNAME;

        public String UNAME
        {
            get { return _UNAME; }
            set { _UNAME = value; }
        }

        private String _UPASS;

        public String UPASS
        {
            get { return _UPASS; }
            set { _UPASS = value; }
        }

        private String _ROLEID;

        public String ROLEID
        {
            get { return _ROLEID; }
            set { _ROLEID = value; }
        }


    }
}