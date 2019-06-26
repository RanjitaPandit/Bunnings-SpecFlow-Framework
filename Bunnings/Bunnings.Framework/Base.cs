using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;


namespace Bunnings.Framework
{
    public class Base
    {
        public readonly BrowserType BrowserType;
        public Base(BrowserType browserType)
        {
            BrowserType = browserType;
        }
        public void InitializeSettings()
        {
            OpenBrowser(BrowserType);
            NaviateSite();
        }
        public virtual void NaviateSite()
        {
            DriverContext.Browser.GoToUrl("https://www.bunnings.com.au");
        }
        public virtual void CloseBrowser()
        {
            DriverContext.Browser.CloseBrowser();
        }
        private void OpenBrowser(BrowserType type)

        {
            switch (type)
            {
                case BrowserType.InternetExplorer:
                    DriverContext.Driver = new InternetExplorerDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Firefox:
                    DriverContext.Driver = new FirefoxDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
                case BrowserType.Chrome:
                    DriverContext.Driver = new ChromeDriver();
                    DriverContext.Browser = new Browser(DriverContext.Driver);
                    break;
            }
            DriverContext.Driver.Manage().Window.Maximize();
        }

       
    }
}
