using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUNGTAMTINHOC.TangDB;

namespace TRUNGTAMTINHOC.TangNghiepVu
{
    public class UserLogin
    {
        string _username;
        string _password;
        string _service;

        public UserLogin(string service, string username, string password)
        {
            _username = username;
            _password = password;
            _service = service;
        }
        public static bool isUser(UserLogin userlogin)
        {
            string nameandpass = userlogin._service + ";DBA Privilege = SYSDBA; User Id=" + userlogin._username + "; Password=" + userlogin._password;
            TruyCapDB.ConnStr = "DATA SOURCE=localhost:1521/" + nameandpass;
            int hasuser = TangDB.UserLoginDB.checkUser(userlogin._username);
            if (hasuser > 0)
                return true;
            return false;
        }

        public static string getLoginedUserName()
        {
            return TangDB.UserLoginDB.getSessionUserName();
        }
    }
}
