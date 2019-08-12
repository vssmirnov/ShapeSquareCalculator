using Calculator.Models;

namespace Calculator.Calculators
{
    internal class NullCalculator : ICalculator
    {
        public double Calculate(IShapeParameter paramters)
        {
            throw new System.NotImplementedException();
        }
    }
}