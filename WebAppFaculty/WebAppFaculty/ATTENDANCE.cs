//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAppFaculty
{
    using System;
    using System.Collections.Generic;
    
    public partial class ATTENDANCE
    {
        public int ID { get; set; }
        public Nullable<int> STUDENT_ID { get; set; }
        public string STD_NAME { get; set; }
        public Nullable<int> COURSE_ID { get; set; }
        public string COURSE_CODE { get; set; }
        public string BATCH_ID { get; set; }
        public Nullable<System.DateTime> ATT_DATE { get; set; }
        public Nullable<int> SEM_ID { get; set; }
        public string SESS_PORTAL { get; set; }
        public string SESS_COURSE { get; set; }
        public string MARK_ATTEND { get; set; }
    
        public virtual SEMESTER SEMESTER { get; set; }
        public virtual COURS COURS { get; set; }
    }
}