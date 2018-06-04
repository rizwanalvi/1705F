using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestInheritance.Model;
namespace TestInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount sa = new SavingAccount();
            sa.AccountNumber = 12122121;
            sa.AccountTitle = "Aptech";
            sa.AccountBalance = 5000;
            sa.WithDraw(5);
          string s = sa.AccountSummary();
            Console.WriteLine(s);
            Console.Read();
        }
    }
}
