using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankLibrary.tests
{
    [TestClass]
    public class CalcInterestTest
    {
        [TestMethod]
        public void  Calculate_AccpetsPNR_ReturnsPI()
        {
            int ExpectedResult = 1000; //Arrange
            ICalcInterest Calc = new CalcInterest(); //Act
            int ActualResult = Calc.Calculate(10000, 1, 10);
            Assert.AreEqual(ExpectedResult, ActualResult);//Assert
        }
    }
}
