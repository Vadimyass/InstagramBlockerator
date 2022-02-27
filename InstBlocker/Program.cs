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
            string password = "";
            string target = "https://www.instagram.com/lord_095/";
            EdgeOptions options = new EdgeOptions();

            EdgeDriver driver = new EdgeDriver(Path.GetFullPath(Directory.GetCurrentDirectory() + @"/Driver"), options);
            driver.Navigate().GoToUrl("https://www.instagram.com");
            driver.Manage().Window.Maximize();
            Thread.Sleep(1000);

            //Заходим в аккаунт
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
            //Зашли в аккаунт

            driver.Navigate().GoToUrl(target); //Заходим на страницу цели ддоса

            try
            {
                //Выбор троеточия
                Thread.Sleep(2500);
                try
                {
                    IWebElement mail3 = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/div[1]/div[2]/button"));
                    mail3.Click();
                }
                catch (NoSuchElementException e)
                {
                    IWebElement mail3 = driver.FindElement(By.XPath("/html/body/div[1]/section/main/div/header/section/div[1]/div[3]/button"));
                    mail3.Click();
                }

                //Пожаловаться
                Thread.Sleep(500);
                IWebElement mail4 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div/button[3]"));
                mail4.Click();

                //Жалоба на аккаунт
                Thread.Sleep(1000);
                IWebElement mail5 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[2]"));
                mail5.Click();

                //Жалоба на контент
                Thread.Sleep(1000);
                IWebElement mail6 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[1]"));
                mail6.Click();

                //Насилие или опасные орг
                Thread.Sleep(1000);
                IWebElement mail8 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[3]/button[7]"));
                mail8.Click();

                //Опасные организации или люди
                Thread.Sleep(1000);
                IWebElement mail9 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/fieldset/div[4]/label/div/input"));
                mail9.Click();

                //Отправить жалобу
                Thread.Sleep(500);
                IWebElement mail10 = driver.FindElement(By.XPath("/html/body/div[6]/div/div/div/div[2]/div/div/div/div[6]/button"));
                mail10.Click();

                //Выходим
                Thread.Sleep(1000);
                driver.Quit();
                
            }
            catch (NoSuchElementException e)
            {
                driver.Quit();
            }
        }
    }
}