using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogi_module_17
{
    public static class Calculator
    {
        // Методы для расчета процентной ставки

        public class OrdinaryAccount : Account
        {
            public override double CalculateInterest()
            {
                double interest = Balance * 0.4;

                if (Balance < 1000)
                    interest -= Balance * 0.2;

                if (Balance >= 1000)
                    interest -= Balance * 0.4;

                return interest;
            }
            public class SalaryAccount : Account
            {
                public override double CalculateInterest()
                {
                    return Balance * 0.5;
                }
            }
            public static class Calculator
            {
                public static void CalculateInterest(Account account)
                {
                    account.Interest = account.CalculateInterest();
                }
            }
        }


    }
}

            

           
