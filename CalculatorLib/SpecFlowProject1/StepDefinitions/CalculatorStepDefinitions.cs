using CalculatorLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator calc;
        private int myresult;
        public CalculatorStepDefinitions(Calculator calculator)
        {
            calc = calculator;
        }
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calc.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calc.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            myresult = calc.Add();
        }
        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            myresult = calc.Subtract();
        }
        [When("the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            myresult = calc.Multiply();
        }
        [When("the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            myresult = calc.Divide();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            myresult.Should().Be(result);
        }
    }
}