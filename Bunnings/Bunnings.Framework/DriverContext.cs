using OpenQA.Selenium;


namespace Bunnings.Framework
{
    public class DriverContext
    {
        public static IWebDriver Driver { get; set; }

        public static Browser Browser { get; set; }
    }
}
