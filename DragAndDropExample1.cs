using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WebTableExample5
{
    [TestClass]
    public class DragAndDropExample1
    {
        [TestMethod]
        public void DragAndDropMethod1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(5000);

            Actions act = new Actions(driver);

            IWebElement srcEle = driver.FindElement(By.XPath("//div[@id='draggable']"));
            IWebElement destEle = driver.FindElement(By.XPath("//div[@id='droppable']"));

            //1. Using DragAndDrop method
            //act.DragAndDrop(srcEle, destEle).Build().Perform();

            //2. Using ClickAndHold method
            act.ClickAndHold(srcEle).MoveToElement(destEle).Release().Build().Perform();

            IWebElement doppedText = driver.FindElement(By.XPath("//div[@id='droppable']/p[contains(text(), 'Dropped!')]"));

            if (doppedText.Displayed)
            {
                Console.WriteLine("Drag and drop passed");
            }
            else
            {
                Console.WriteLine("Drag and drop failed");
            }

            Thread.Sleep(4000);

            driver.Close();
            driver.Quit();
        }
    }
}
