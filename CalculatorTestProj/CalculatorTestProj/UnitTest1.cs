using CalcLib;

namespace CalculatorTestProj
{
    public class UnitTest1
    {
        Calculator calculator;
        [Fact]
        public void Test1()
        {
            int num1, num2;
            num1 = 10; num2=10;
            Assert.Equal(num1, num2);
        }
        [Fact]
        public void AddTest()
        {
            calculator = new Calculator();
            double num1, num2,result;
            num1 = 10; num2 = 10;
            result=20;
            Assert.Equal(result,calculator.Add(num1,num2));
        }
        [Fact]
        public void SubTest()
        {
            calculator = new Calculator();
            double num1, num2, result;
            num1 = 10; num2 = 5;
            result = 5;
            Assert.Equal(result, calculator.Sub(num1, num2));
        }
        [Fact]
        public void DivTest()
        {
            calculator = new Calculator();
            double num1, num2, result;
            num1 = 10; num2 = 10;
            result = 1;
            Assert.Equal(result, calculator.Div(num1, num2));
        }
        [Fact]
        public void MultiTest()
        {
            calculator = new Calculator();
            double num1, num2, result;
            num1 = 10; num2 = 10;
            result = 100;
            Assert.Equal(result, calculator.Multi(num1, num2));
        }
        [Fact]
        public void AvgTest()
        {
            calculator = new Calculator();
            double num1, num2, result;
            num1 = 10; num2 = 10;
            result = 10;
            Assert.Equal(result, calculator.Avg(num1, num2));
        }
    }
}