namespace Calculator.Models
{
    /// <summary>
    /// Параметры треугольника
    /// </summary>
    public sealed class TriangleParameter: IShapeParameter 
    {
        /// <summary>
        /// Сторона треугольника А
        /// </summary>
        public long SideA { get; set; }   
        
        /// <summary>
        /// Сторона треугольника Б
        /// </summary>
        public long SideB { get; set; }   
        
        /// <summary>
        /// Сторона треугольника С
        /// </summary>
        public long SideC { get; set; }   
    }
}