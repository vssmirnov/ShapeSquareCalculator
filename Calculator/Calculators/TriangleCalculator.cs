using System;
using Calculator.Models;

namespace Calculator.Calculators
{
    internal class TriangleCalculator : ICalculator
    {
        public double Calculate(IShapeParameter paramters)
        {
            var triangle = paramters as TriangleParameter;

            var p = (triangle.SideA + triangle.SideB + triangle.SideC) / 2;
 
            return Math.Sqrt(p * (p - triangle.SideA) * (p - triangle.SideB) * (p - triangle.SideC));
        }
    }
}