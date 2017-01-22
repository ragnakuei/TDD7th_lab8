using System;
using TechTalk.SpecFlow;

namespace CalculatorSampleTests
{
    [Binding]
    public class MyCalculatorSteps
    {
        [Given(@"在第一個輸入項輸入 (.*)")]
        public void Given在第一個輸入項輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"在第二個輸入項輸入 (.*)")]
        public void Given在第二個輸入項輸入(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"按下 Add 按鈕")]
        public void When按下Add按鈕()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"螢幕上的結果應為 (.*)")]
        public void Then螢幕上的結果應為(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
