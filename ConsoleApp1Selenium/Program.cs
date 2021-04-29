using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Selenium
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Heta");
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Learn Automation");
            driver.Quit();
        }
    }
}
