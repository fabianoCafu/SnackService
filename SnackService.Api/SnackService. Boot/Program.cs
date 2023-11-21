using System;
using OpenQA.Selenium;
using prmToolkit.Selenium;
using prmToolkit.Selenium.Enum;

namespace SnackService.Boot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var localDriver = AppDomain.CurrentDomain.BaseDirectory.ToString();
            var webDriver = WebDriverFactory.CreateWebDriver(Browser.Chrome, $"{localDriver}/driver");

            webDriver.LoadPage(TimeSpan.FromSeconds(5), "https://web.whatsapp.com/");
        }
    }
}
