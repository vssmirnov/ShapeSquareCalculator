using Calculator.Models;

namespace Calculator.Calculators
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    public interface ICalculator
    {
        /// <summary>
        /// Расчитать площадь фигуры по параметрам
        /// </summary>
        double Calculate(IShapeParameter paramters);
    }
}