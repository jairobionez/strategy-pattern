using StrategyPattern.Prompt.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Prompt.Business.Operations
{
    public class Multiply : ICalculator
    {
        public string Type => "Multiply";

        public decimal Execute(decimal vl1, decimal vl2)
        {
            return vl1 * vl2;
        }
    }
}
