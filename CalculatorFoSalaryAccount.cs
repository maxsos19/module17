using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrincipleOfOpenness_Closeness
{
    public class CalculatorFoSalaryAccount: IACommonInterfaceForAllAccounts
    {
        public void CalculateInterest (Account account)
        {
            account.Interest = account.Balance * 0.5;
        }


    }
}
