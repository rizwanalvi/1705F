using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestInheritance.Model
{
   public class SavingAccount : Account
    {
      
        public void Deposit(double amount)
        {
            base.AccountBalance += amount;
                      
        }

        public void WithDraw(double amount)
        {
            base.AccountBalance -= amount;

        }
        public override string AccountSummary()
        {
            string S = String.Format("---------------------\nAccount Type :Saving\nAccount Number : {0}\nAccount Title : {1}\n{2}\n---------------------------", base.AccountTitle,base.AccountNumber,base.AccountBalance);
            return S;
        }
    }
}
