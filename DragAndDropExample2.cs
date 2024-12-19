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
    public class DragAndDropExample2
    {
        [TestMethod]
        public void DragAndDropMethod2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.dhtmlgoodies.com/scripts/drag-drop-custom/demo-drag-drop-3.html");
            driver.Manage().Window.Maximize();
            Thread.Sleep(3000);

            Actions act = new Actions(driver);

            //Source Elements

            IWebElement Oslo = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Oslo')][2]"));
            IWebElement Stockholm = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Stockholm')][2]"));
            IWebElement Washington = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Washington')][2]"));
            IWebElement Copenhagen = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Copenhagen')][2]"));
            IWebElement Seoul = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Seoul')][2]"));
            IWebElement Rome = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Rome')][2]"));
            IWebElement Madrid = driver.FindElement(By.XPath("//div[@class='dragableBox' and contains(text(), 'Madrid')][2]"));

            //Destination Elements

            IWebElement Italy = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'Italy')]"));
            IWebElement Spain = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'Spain')]"));
            IWebElement Norway = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'Norway')]"));
            IWebElement Denmark = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'Denmark')]"));
            IWebElement SouthKorea = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'South Korea')]"));
            IWebElement Sweden = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'Sweden')]"));
            IWebElement UnitedStates = driver.FindElement(By.XPath("//div[@class='dragableBoxRight' and contains(text(), 'United States')]"));

            act.DragAndDrop(Rome, Italy).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Madrid, Spain).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Oslo, Norway).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Copenhagen, Denmark).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Seoul, SouthKorea).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Stockholm, Sweden).Build().Perform();
            Thread.Sleep(2000);

            act.DragAndDrop(Washington, UnitedStates).Build().Perform();
            Thread.Sleep(2000);


            driver.Close();
            driver.Quit();
        }
    }
}
