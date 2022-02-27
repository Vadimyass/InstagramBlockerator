using OpenQA.Selenium;
using System;
using OpenQA.Selenium.Edge;
using System.Threading;
using System.IO;

namespace ConsoleApp1
{
    class entryPoint
    {
        static void Main(string[] args)
        {
            string acc = "Vadimyass";
            string password = "q_vadimyass";
            string receiver = "the person you want to send to";
            string msg = "your messige";
            int msgnum = 100;
            EdgeOptions options = new EdgeOptions();

            EdgeDriver driver = new EdgeDriver(Path.GetFullPath(@"V:/InstagramKek/ConsoleApp1/bin"), options);
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


            mail3.Click();
            Thread.Sleep(100);
            IWebElement mail4 = driver.FindElement(By.XPath("/html/body/div[4]/div/div/div/div[3]/button[2]"));

            mail4.Click();
            Thread.Sleep(1000);
            IWebElement mail5 =
                driver.FindElement(By.XPath("/html/body/div[1]/section/nav/div[2]/div/div/div[3]/div/div[2]/a"));

            mail5.Click();
            Thread.Sleep(1000);
            IWebElement mail6 =
                driver.FindElement(
                    By.XPath("/html/body/div[1]/section/div/div[2]/div/div/div[2]/div/div[3]/div/button"));

            mail6.Click();
            Thread.Sleep(100);
            IWebElement mail7 =
                driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[2]/div[1]/div/div[2]/input"));

            Thread.Sleep(100);
            mail7.SendKeys(receiver);
            Thread.Sleep(1000);

            bool IsElementPresent(By by)
            {
                try
                {
                    driver.FindElement(by);
                    return true;
                }
                catch (NoSuchElementException)
                {
                    return false;
                }
            }

            for (int i = 1; i < 10; i++)
            {

                if (IsElementPresent(By.XPath(@"/html/body/div[5]/div/div/div[2]/div[2]/div[" + i + "]")) == true)
                {
                    Thread.Sleep(2000);
                    IWebElement mail8 =
                        driver.FindElement(By.XPath(@"/html/body/div[5]/div/div/div[2]/div[2]/div[" + i + "]"));
                    if (mail8.Text.StartsWith(receiver))
                    {
                        Console.WriteLine(mail8.Text);
                        mail8.Click();
                        break;
                    }
                }





            }

            Thread.Sleep(2000);
            IWebElement mail9 =
                driver.FindElement(By.XPath("/html/body/div[5]/div/div/div[1]/div/div[2]/div/button/div"));


            mail9.Click();
            Thread.Sleep(2000);
            IWebElement mail10 = driver.FindElement(By.XPath(
                "/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[2]/textarea"));



            for (int x = 0; x <= msgnum; x++)
            {
                mail10.SendKeys(msg);
                IWebElement mail11 = driver.FindElement(By.XPath(
                    "/html/body/div[1]/section/div/div[2]/div/div/div[2]/div[2]/div/div[2]/div/div/div[3]/button"));
                mail11.Click();
                Console.WriteLine(x);
            }


        }
    }
}