using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UltimateApp.Test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void AddTest()
        {

            int? retVal = Calculator.calculate(2, 3, Operation.Add);

            Assert.AreEqual(5, retVal);

        }
    }
}
