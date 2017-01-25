using CalculatorSample;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CalculatorSampleTests
{
    [Binding]
    [Scope(Feature = "MyCalculator")]
    public class MyCalculatorSteps
    {
        private MyCalculator target;

        [BeforeScenario]
        private void BeforeScenario()
        {
            this.target = new MyCalculator();
        }

        [Given(@"在第一個輸入項輸入 (.*)")]
        public void Given在第一個輸入項輸入(decimal first)
        {
            ScenarioContext.Current.Set<decimal>(first, "first");
        }

        [Given(@"在第二個輸入項輸入 (.*)")]
        public void Given在第二個輸入項輸入(decimal second)
        {
            ScenarioContext.Current.Set<decimal>(second, "second");
        }

        [When(@"按下 Add 按鈕")]
        public void When按下Add按鈕()
        {
            var first = ScenarioContext.Current.Get<decimal>("first");
            var second = ScenarioContext.Current.Get<decimal>("second");
            var actual = target.Add(first, second);
            ScenarioContext.Current.Set<decimal>(actual, "actual");
        }

        [Then(@"螢幕上的結果應為 (.*)")]
        public void Then螢幕上的結果應為(decimal expected)
        {
            var actual = ScenarioContext.Current.Get<decimal>("actual");
            Assert.AreEqual(expected, actual);
        }
    }
}
