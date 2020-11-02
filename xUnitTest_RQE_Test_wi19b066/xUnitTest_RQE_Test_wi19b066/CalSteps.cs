using System;
using TechTalk.SpecFlow;
using Xunit;

namespace xUnitTest_RQE_Test_wi19b066
{
    [Binding]
    public class CalSteps
    {

        calculator calc;


        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(int p0)
        {
            calc = new calculator();
            calc.sine(p0);
        }
        
        [When(@"we take the sine of the number")]
        public void WhenWeTakeTheSineOfTheNumber()
        {
            
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(Decimal p0)
        {
            var expected = Decimal.ToDouble(p0);
            var actual = calc.Result;
            Assert.Equal(expected, actual, 5);
        }
    }
}
