using StrategyPattern.Prompt.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace StrategyPattern.Prompt.Providers
{
    public class CalculatorProvider
    {
        private Dictionary<string, ICalculator> operations = new Dictionary<string, ICalculator>();

        public CalculatorProvider()
        {
            RegisterOperations();
        }

        private void RegisterOperations()
        {
            var ops = Assembly.GetExecutingAssembly()
                        .GetTypes()
                        .Where(o => typeof(ICalculator).IsAssignableFrom(o) && !o.IsInterface);

            foreach (Type operation in ops)
            {
                ICalculator typeOperation = (ICalculator)Activator.CreateInstance(operation);

                var op = operation.GetProperties()
                            .FirstOrDefault(s => s.Name == "Type")
                            .GetValue(typeOperation).ToString();

                operations.Add(op, typeOperation);
            }
        }

        public ICalculator GetOperation(string type)
        {
            ICalculator typeOperation = operations[type];

            if(typeOperation == null)
                throw new Exception("Nenhum operação encontrada");

            return typeOperation;
        }
    }
}
