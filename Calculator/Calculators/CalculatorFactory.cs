using System;
using System.Collections.Generic;
using Calculator.Models;

namespace Calculator.Calculators
{
    internal sealed class CalculatorFactory: ICalculatorFactory
    {
        public static readonly CalculatorFactory Singlton = new CalculatorFactory();
        private readonly NullCalculator nullCalculator = new NullCalculator();
        private readonly IDictionary<Type, ICalculator> Calculators = 
            new Dictionary<Type, ICalculator>();

        private CalculatorFactory()
        {
            InitDefaultCalculators();
        }

        private void InitDefaultCalculators()
        {            
            AddCalculator(typeof(TriangleParameter), new TriangleCalculator());
            AddCalculator(typeof(SquareParameter), new SquareCalculator());
        }

        public void AddCalculator<T>(Type typeShape, T calculator) where T: ICalculator
        {
            if (!Calculators.ContainsKey(typeShape))
            {
                Calculators.Add(typeShape, calculator);
            }
        }

        public ICalculator GetCalculator(Type typeShape)
        {
            if (Calculators.TryGetValue(typeShape, out var calculator)){
                return calculator;
            };

            return nullCalculator;
        }
    }
}