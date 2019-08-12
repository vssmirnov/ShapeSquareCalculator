using System;

namespace Calculator.Calculators
{
    internal interface ICalculatorFactory
    {
        void AddCalculator<T>(Type typeShape, T calculator) where T: ICalculator;
        ICalculator GetCalculator(Type typeShape);
    }
}