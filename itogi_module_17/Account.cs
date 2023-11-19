using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itogi_module_17
{
    public abstract class Account
    {
        public string Type { get; set; }
        public double Balance { get; set; }
        public abstract double CalculateInterest();
        public double Interest { get; set; }
    }
   
}