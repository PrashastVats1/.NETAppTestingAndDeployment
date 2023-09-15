using CalcDockerAssignment;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDockerAssignment
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestAddition()
        {
            double num1 = 5;
            double num2 = 10;
            double expected = num1 + num2;

            double result = Program.Add(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestSubtraction()
        {
            double num1 = 10;
            double num2 = 5;
            double expected = num1 - num2;

            double result = Program.Subtract(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestMultiplication()
        {
            double num1 = 5;
            double num2 = 10;
            double expected = num1 * num2;

            double result = Program.Multiply(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivision()
        {
            double num1 = 10;
            double num2 = 2;
            double expected = num1 / num2;

            double result = Program.Divide(num1, num2);

            Assert.AreEqual(expected, result);
        }

        [Test]
        public void TestDivisionByZero()
        {
            double num1 = 5;
            double num2 = 0;

            Assert.Throws<DivideByZeroException>(() => Program.Divide(num1, num2));
        }

        [Test]
        public void TestExponentiation()
        {
            double num1 = 2;
            double num2 = 3;
            double expected = 8; // 2^3 = 8

            double result = Program.Exponentiate(num1, num2);

            Assert.AreEqual(expected, result);
        }
    }

}
