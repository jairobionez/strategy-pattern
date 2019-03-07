using StrategyPattern.Prompt.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Prompt.Business.Operations
{
    public class Divide : ICalculator
    {
        public string Type => "Divide";

        public decimal Execute(decimal vl1, decimal vl2)
        {
            if (vl2 == 0)
                throw new Exception("0 não é divisivel");

            return vl1 / vl2;
        }
    }
}
