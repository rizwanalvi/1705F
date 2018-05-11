using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
namespace WebHRM.Models
{
    public class LoginDb
    {
        SqlConnection _sqlConn = null;
        List<Login> _loginData = null;
        public LoginDb() {
            _sqlConn = new SqlConnection(@"Data Source=FACULTY18;Initial Catalog=HMR_DB;Integrated Security=False;User ID=sa;Password=sa9;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            _sqlConn.Open();
        }

        public List<Login> GetLoginTable() {
            _loginData = new List<Login>();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM Login",_sqlConn);
            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read()) {
                _loginData.Add(new Login { ID = dReader.GetInt32(0),UNAME = dReader.GetString(1),UPASS = dReader.GetString(2),ROLEID= dReader.GetString(3) });
                    
            }

            return _loginData;
        }
        public int AddLoginInfo(Login lg) {
            SqlCommand _cmd = new SqlCommand("INSERT INTO LOGIN(UNAME,UPASS,ROLEID) VALUES(@UNAME,@UPASS,@ROLEID)", _sqlConn);
            _cmd.Parameters.AddWithValue("@UNAME",lg.UNAME);
            _cmd.Parameters.AddWithValue("@UPASS", lg.UPASS);
            _cmd.Parameters.AddWithValue("@ROLEID", lg.ROLEID);
            return _cmd.ExecuteNonQuery();
        }
    }
}