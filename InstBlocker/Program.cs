using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Edge;
using System.Threading;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class entryPoint
    {
        static void Main(string[] args)
        {
            string acc = "plankcd17";
            string password = "kek";
            string target = "ссылка на таргет";
            EdgeOptions options = new EdgeOptions();

            EdgeDriver driver = new EdgeDriver(Path.GetFullPath(Directory.GetCurrentDirectory() + @"/Driver"), options);
            driver.Navigate().GoToUrl("https://www.instagram.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);
            IWebElement mail1 =
                driver.FindElement(By.XPath(
                    "/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[1]/div/label/input"));
            IWebElement mail =
                driver.FindElement(By.XPath(
                    "/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[2]/div/label/input"));
            IWebElement mail2 =
                driver.FindElement(
                    By.XPath("/html/body/div[1]/section/main/article/div[2]/div[1]/div/form/div/div[3]/button/div"));




            mail.SendKeys(password);


            mail1.SendKeys(acc);
            mail2.Click();
            Thread.Sleep(2500);
            IWebElement mail3 = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/div/div/div/button"));

            driver.Navigate().GoToUrl(target);
            Thread.Sleep(250);
            IWebElement mail4 = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/div[1]/div[2]/button"));
            mail4.Click();
            Thread.Sleep(250);
            IWebElement mail5 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div/button[3]"));
            mail5.Click();
            Thread.Sleep(500);
            IWebElement mail6 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[2]"));
            mail6.Click();
            Thread.Sleep(500);
            IWebElement mail7 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[1]"));
            mail7.Click();
            Thread.Sleep(500);
            IWebElement mail8 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[7]"));
            mail8.Click();
            Thread.Sleep(500);
            IWebElement mail9 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/fieldset/div[4]/label/div/input"));
            mail9.Click();
            Thread.Sleep(250);
            IWebElement mail10 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[6]/button"));
            mail10.Click();
        }
    }
}