using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MyFirstApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Multiply(2, 3) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            Assert.IsTrue(calculator.Divide(6, 3) == 2);
        }
    }
}