using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TRUNGTAMTINHOC.TangNghiepVu;

namespace TRUNGTAMTINHOC.TangDB
{
    public class UserLoginDB
    {
        public static int checkUser(string username)
        {
            string query = "select username from dba_users where username = '" + username + "'";
            int result = TruyCapDB.Instance.ExecuteParameterQuery(query).Rows.Count;
            return result;
        }

        public static string getSessionUserName()
        {
            return TruyCapDB.Instance.ExecuteScalar("SELECT SYS_CONTEXT ('USERENV', 'SESSION_USER') FROM DUAL").ToString();
        }
    }
}
