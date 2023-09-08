using OurCalcLib;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly SimpleCalc calc = new SimpleCalc();
        private int myresult;
        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calc.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calc.SecindNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            myresult = calc.Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            myresult.Should().Be(result);
        }
    }
}