using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.Model
{
   public class Account
    {
        public String AccountTitle { get; set; }
        public int AccountNumber { get; set; }
        public double AccountBalance { get; set; }

        public virtual String AccountSummary() {
            String s = String.Format("{0} {1}{2}",this.AccountNumber,this.AccountTitle,this.AccountBalance);
            return s;

        }
    }
}
