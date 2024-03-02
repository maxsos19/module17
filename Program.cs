using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ThePrincipleOfOpenness_Closeness
{
    public class Program
    {

        static void Main(string[] args)
        {

            // расчет для обычного аккаунта
            IACommonInterfaceForAllAccounts ac = new CalculatorForACommonAccount();
            Account account = new Account();
            ac.CalculateInterest(account);

            //расчет для зарплатного счета
            IACommonInterfaceForAllAccounts ac1 = new CalculatorFoSalaryAccount();
            Account account1 = new Account();
            ac1.CalculateInterest(account1);

        }

    }
}
