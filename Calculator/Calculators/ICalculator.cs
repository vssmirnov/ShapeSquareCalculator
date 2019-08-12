using Calculator.Models;

namespace Calculator.Calculators
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Расчитать площадь
        /// </summary>
        long Calculate(IShapeParameter paramters);
    }
}