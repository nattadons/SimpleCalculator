using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;  

[TestClass]
public class CalculatorTests
{
    [TestMethod]
    public void TestAddition()
    {
 
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(5, 3, "+");
        Assert.AreEqual(8, result);
    }

    [TestMethod]
    public void TestDivision()
    {
        Calculator calculator = new Calculator();
        double result = calculator.Calculate(10, 2, "/");
        Assert.AreEqual(5, result);
    }

    [TestMethod]
    [ExpectedException(typeof(DivideByZeroException))]
    public void TestDivideByZero()
    {
        Calculator calculator = new Calculator();
        calculator.Calculate(10, 0, "/");
    }
}