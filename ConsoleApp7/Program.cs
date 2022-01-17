using OpenQA.Selenium.Firefox;
using System;

namespace ConsoleApp7
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the browser in which you want to test");
           string browser = Console.ReadLine();
            switch (browser)
            {
                case "Firefox":
                    FirefoxDriver Driver = new FirefoxDriver();
            }
        }
    }
}
