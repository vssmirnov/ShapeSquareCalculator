namespace Calculator.Models
{
    /// <summary> 
    /// Результат вычесления
    /// </summary>
    public class CalculatingResult
    {
        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public double Result { get; set; } 

        /// <summary>
        /// Флаг успешности вычесления, true - успешно, false - произошла ошибка
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Ошибка при вычесление, если IsSuccess равен true, то сообщения об ошибке нет, иначе выводится текст об ошибке
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}