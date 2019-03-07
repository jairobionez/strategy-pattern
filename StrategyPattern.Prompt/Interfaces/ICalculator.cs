using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.Prompt.Interfaces
{
    public interface ICalculator
    {
        string Type { get; }

        decimal Execute(decimal vl1, decimal vl2);
    }
}