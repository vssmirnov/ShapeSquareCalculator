using System;
using Calculator.Models;

namespace Calculator.Calculators
{
    internal class SquareCalculator : ICalculator
    {
        public double Calculate(IShapeParameter paramters)
        {
            var square = paramters as SquareParameter;
            return square.Radius * 2.0 * Math.PI;
        }
    }
}