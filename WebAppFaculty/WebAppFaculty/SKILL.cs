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
    
    public partial class SKILL
    {
        public int ID { get; set; }
        public Nullable<int> BATCH_NO { get; set; }
        public string TIME_SLOT { get; set; }
        public Nullable<int> SEM_ID { get; set; }
        public string CURRENT_SKILL { get; set; }
        public string NEXT_SKILL { get; set; }
        public Nullable<int> CURRI_ID { get; set; }
        public Nullable<System.DateTime> START_DATE { get; set; }
        public Nullable<int> STC_SPACE { get; set; }
        public Nullable<int> FA_ID { get; set; }
    
        public virtual BATCH_REGISTRATION BATCH_REGISTRATION { get; set; }
        public virtual SEMESTER SEMESTER { get; set; }
    }
}
