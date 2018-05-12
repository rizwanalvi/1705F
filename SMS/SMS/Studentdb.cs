using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS
{
  public  class Studentdb
    {
        SqlConnection _sqlConn = null;
        List<Student> _loginTable = null;
        public Studentdb()
        {
            _sqlConn = new SqlConnection(@"Data Source=faculty18;Initial Catalog=1705Fdb;Integrated Security=True");
            // _sqlConn.Open();
        }

        public List<Student> GetLoginTable()
        {
            _sqlConn.Open();
            _loginTable = new List<Student>();
            SqlCommand _cmd = new SqlCommand("SELECT * FROM tStudent", _sqlConn);
            SqlDataReader dReader = _cmd.ExecuteReader();
            while (dReader.Read())
            {

                _loginTable.Add(new Student {
                    ID = dReader.GetInt32(0),
                    StudentName = dReader.GetString(1),
                    FatherName = dReader.GetString(2),
                    DateOfBirth = dReader.GetDateTime(3),
                    Gender = dReader.GetString(5),
                    BatchNo = dReader.GetString(11),
                    Address = dReader.GetString(4),
                    ContactNo01 = dReader.GetString(6),
                    ContactNo02 = dReader.GetString(7),
                    ContactNo03 = dReader.GetString(8),
                    Course = dReader.GetString(9),
                    CurrentSkill = dReader.GetString(10)
                });
            }
            _sqlConn.Close();
            return _loginTable;
        }

        public void AddData(Student std)
        {
            SqlCommand _cmd = new SqlCommand("INSERT INTO tStudent (StudentName,FatherName, DateOfBirth,Gender, BatchNo,Address,ContactNo01,ContactNo02,ContactNo03, Course,CurrentSkill ) VALUES(@StudentName,@FatherName,@DateOfBirth,@Gender,@BatchNo,@Address,@ContactNo01,@ContactNo02,@ContactNo03,@Course,@CurrentSkill)", _sqlConn);
            _cmd.Parameters.AddWithValue("@StudentName", std.StudentName);
            _cmd.Parameters.AddWithValue("@FatherName", std.FatherName);
            _cmd.Parameters.AddWithValue("@Address", std.Address);
            _cmd.Parameters.AddWithValue("@Gender", std.Gender);
            _cmd.Parameters.AddWithValue("@BatchNo", std.BatchNo);
            _cmd.Parameters.AddWithValue("@ContactNo01", std.ContactNo01);
            _cmd.Parameters.AddWithValue("@ContactNo02", std.ContactNo02);
            _cmd.Parameters.AddWithValue("@ContactNo03", std.ContactNo03);
            _cmd.Parameters.AddWithValue("@DateOfBirth", std.DateOfBirth);
            _cmd.Parameters.AddWithValue("@Course", std.Course);
            _cmd.Parameters.AddWithValue("@CurrentSkill", std.CurrentSkill);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();
        }
        public void UpdateData(Student std)
        {

            SqlCommand _cmd = new SqlCommand("UPDATE tLogin SET StudentName=@StudentName,FatherName=@FatherName,Address=@Address,Gender=@Gender,BatchNo=@BatchNo,ContactNo01=@ContactNo01=ContactNo02=@ContactNo02,ContactNo03=@ContactNo03,DateOfBirth=@DateOfBirth,Course=@Course,CurrentSkill=@CurrentSkill) WHERE ID=@id", _sqlConn);
            _cmd.Parameters.AddWithValue("@id", std.ID);
            _cmd.Parameters.AddWithValue("@StudentName", std.StudentName);
            _cmd.Parameters.AddWithValue("@FatherName", std.FatherName);
            _cmd.Parameters.AddWithValue("@Address", std.Address);
            _cmd.Parameters.AddWithValue("@Gender", std.Gender);
            _cmd.Parameters.AddWithValue("@BatchNo", std.BatchNo);
            _cmd.Parameters.AddWithValue("@ContactNo01", std.ContactNo01);
            _cmd.Parameters.AddWithValue("@ContactNo02", std.ContactNo02);
            _cmd.Parameters.AddWithValue("@ContactNo03", std.ContactNo03);
            _cmd.Parameters.AddWithValue("@DateOfBirth", std.DateOfBirth);
            _cmd.Parameters.AddWithValue("@Course", std.Course);
            _cmd.Parameters.AddWithValue("@CurrentSkill", std.CurrentSkill);
            _sqlConn.Close();


        }
        public void DeleteData(int Id)
        {

            _sqlConn.Open();
            SqlCommand _cmd = new SqlCommand("DELETE From tStudent where id = @id", _sqlConn);
            _cmd.Parameters.AddWithValue("@id", Id);
            _cmd.ExecuteNonQuery();
            _sqlConn.Close();

        }
    }
}
