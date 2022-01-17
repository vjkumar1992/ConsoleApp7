using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Threading;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = null;
            Console.WriteLine("Please enter the browser in which you want to test");
            string browser = Console.ReadLine();
            browser = browser.ToLower();
            switch (browser)
            {
                case "firefox":
                    driver = new FirefoxDriver();

                    driver.Url = "https://demo.creativeitem.com/bayanno/login";

                    break;
                case "chrome":
                    driver = new ChromeDriver();
                    driver.Url = "https://demo.creativeitem.com/bayanno/login";
                    break;
                case "IE":
                    driver.Url = "https://demo.creativeitem.com/bayanno/login";
                    break;

            }
        }
    }
}