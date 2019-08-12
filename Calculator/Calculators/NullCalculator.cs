using Calculator.Models;

namespace Calculator.Calculators
{
    internal class NullCalculator : ICalculator
    {
        public long Calculate(IShapeParameter paramters)
        {
            throw new System.NotImplementedException();
        }
    }
}