using Microsoft.VisualStudio.TestTools.UnitTesting;

using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace MyFirstApp.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Add(2, 2) == 4);
        }

        [TestMethod()]
        public void SubstractTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Substract(2, 2) == 0);
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Multiply(2, 3) == 6);
        }

        [TestMethod()]
        public void DivideTest()
        {
            Calculator calculator = new Calculator();
            IsTrue(calculator.Divide(6, 3) == 2);
        }
    }
}