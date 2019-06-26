using OpenQA.Selenium;


namespace Bunnings.Framework
{
    public enum BrowserType
    {
        InternetExplorer,
        Firefox,
        Chrome
    }
    public class Browser
    {
        private readonly IWebDriver _driver;

        public Browser(IWebDriver driver) => _driver = driver;

        public BrowserType Type { get; set; }

        public void GoToUrl(string url)
        {
            DriverContext.Driver.Url = url;
        }
        public void CloseBrowser()
        {
            DriverContext.Driver.Close();
        }
    }
}
