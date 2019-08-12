using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using Calculator.Models;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorApiTest
    {
        [TestMethod]
        public void Test_TriangleCalculator()
        {
            var api = new Calculator.CalculatorApi(); 
            var result = api.CalculateShapeSquare<TriangleParameter>(new TriangleParameter(){SideA = 3, SideB = 4, SideC = 5});
            Assert.AreEqual(result.Result, 6);
        }
        
        [TestMethod]
        public void Test_SquareCalculator()
        {
            var api = new Calculator.CalculatorApi(); 
            var result = api.CalculateShapeSquare<SquareParameter>(new SquareParameter(){Radius = 4});
            Assert.AreEqual(result.Result, 25.12);
        }
        
        [TestMethod]
        public void Test_OtherCalculator()
        {
            var api = new Calculator.CalculatorApi(); 
            IShapeParameter otherShape = null;
            var result = api.CalculateShapeSquare<IShapeParameter>(otherShape);
            Assert.AreEqual(result.IsSuccess, false);
        }
    }
}
