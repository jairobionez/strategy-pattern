using StrategyPattern.Prompt.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Prompt.Business.Operations
{
    public class Subtract : ICalculator
    {
        public string Type => "Subtract";

        public decimal Execute(decimal vl1, decimal vl2)
        {
            return vl1 - vl2;
        }
    }
}
