using System;
using Calculator.Models;
using Calculator.Calculators;

namespace Calculator
{
    /// <summary>
    /// Апи для вычисления площадей фигур
    /// </summary>
    public sealed class CalculatorApi
    {
        /// <summary>
        /// Добавить новый калькулятор
        /// </summary>
        public void AddNewCalculator(Type typeShape, ICalculator calculator){
            CalculatorFactory.Singlton.AddCalculator(typeShape, calculator);
        }

        /// <summary>
        /// Расчитать площадь
        /// </summary>
        public CalculatingResult CalculateShapeSquare<T>(T parameterSquare) where T: IShapeParameter
        {
            if (parameterSquare == null) {
                return new CalculatingResult(){IsSuccess = false, ErrorMessage = "Передан параметр со значением null"};
            }

            var calculator = CalculatorFactory.Singlton.GetCalculator(parameterSquare.GetType());
            if (calculator.GetType() == typeof(NullCalculator)){
                return new CalculatingResult(){IsSuccess = false, ErrorMessage = "Не найден калькулятор для заданной фигуры"};
            }

            try{
                var result = calculator.Calculate(parameterSquare);
                return new CalculatingResult(){Result = result, IsSuccess = true, ErrorMessage = string.Empty};
            } catch (Exception ex){
                return new CalculatingResult(){IsSuccess = false, ErrorMessage = ex.Message};
            }
        } 
    }
}
