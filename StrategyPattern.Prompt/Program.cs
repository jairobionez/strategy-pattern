using StrategyPattern.Prompt.Business;
using StrategyPattern.Prompt.Interfaces;
using StrategyPattern.Prompt.Providers;
using System;

namespace StrategyPattern.Prompt
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculator strategy;
            CalculatorProvider provider = new CalculatorProvider();
            decimal result = 0;
            int chose = -1;

            Console.WriteLine("Escolha uma operação: ");
            Console.WriteLine("1: Somar");
            Console.WriteLine("2: Subtrair");
            Console.WriteLine("3: Multiplicar");
            Console.WriteLine("4: Dividir");

            while (chose != 0)
            {
                Console.Write("Escolha: ");
                chose = Convert.ToInt32(Console.ReadLine());

                switch (chose)
                {
                    case 1:
                        strategy = provider.GetOperation("Add");                        
                        break;
                    case 2:
                        strategy = provider.GetOperation("Subtract");
                        break;
                    case 3:
                        strategy = provider.GetOperation("Multiply");
                        break;
                    case 4:
                        strategy = provider.GetOperation("Divide");        
                        break;
                    default:
                        strategy = null;
                        break;                    
                }

                result = strategy.Execute(2, 2);

                if (strategy != null)
                    Console.WriteLine($"{strategy.GetType().Name}: {result}");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
    }
}
