﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThePrincipleOfOpenness_Closeness
{
    public class CalculatorForACommonAccount: IACommonInterfaceForAllAccounts
    {
        public void CalculateInterest(Account account)
        {
          
          account.Interest = account.Balance * 0.4;

                if (account.Balance < 1000)
                    account.Interest -= account.Balance * 0.2;
                if (account.Balance >= 1000)
                    account.Interest -= account.Balance * 0.4;

          

        }
    }
}
