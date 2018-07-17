using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace WebAppEx01.Models
{
    public class Student
    {
        public int StdID { get; set; }
        public String StdName { get; set; }
        public int BatchNo { get; set; }
        public String TimeSlot { get; set; }
        public bool IsAttended { get; set; }

        public List<Student> getAllStudents() {
            List<Student> _lst = new List<Student>();

            _lst.Add(new Student() { StdID=1001,StdName="Majid",BatchNo=1705,TimeSlot="F",IsAttended=true});
            _lst.Add(new Student() { StdID = 1002, StdName = "kmaran", BatchNo = 1705, TimeSlot = "F", IsAttended = false });
            _lst.Add(new Student() { StdID = 1003, StdName = "Rehan", BatchNo = 1705, TimeSlot = "F", IsAttended = true });
            _lst.Add(new Student() { StdID = 1004, StdName = "Salman", BatchNo = 1705, TimeSlot = "F", IsAttended = false });
            return _lst;
        }
        
    }
}