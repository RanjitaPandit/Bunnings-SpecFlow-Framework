using Bunnings.Framework;
using TechTalk.SpecFlow;

namespace Bunnings.Specflow
{
    [Binding]
    public class InitHook : Base
    {
        public InitHook() : base(BrowserType.Chrome)
        {

        }
        [BeforeScenario]
        public void BeforeScenario()
        {
            InitializeSettings();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseBrowser();
        }
    }
}
