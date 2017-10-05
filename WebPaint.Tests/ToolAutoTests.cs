using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Opera;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace WebPaintAutoTests
{
    public class ToolAutoTests
    {
        POM obj;
        static IWebDriver driver = null;

        [OneTimeSetUp]
        public void DriverPath()
        {
            driver = new EdgeDriver();
            obj = new POM(driver);
        }

        [OneTimeTearDown]
        public static void TearDown()
        {
            driver.Quit();
        }

        [SetUp]
        public void TestUp()
        {
            driver.Navigate().GoToUrl("http://localhost:54844/main.html");
        }

        [TestCase("tNew", "addTab")]
        [TestCase("tClose", "closeTab")]
        [TestCase("tCloseAll", "closeAllTabs")]
        public void TestTabTool(string elementId, string res)
        {
            obj.FindElement(elementId).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("tSave", "saveFile")]
        [TestCase("tLoad", "openFile")]
        public void TestFileTool(string elementId, string res)
        {
            obj.FindElement(elementId).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("tSaveC", "saveCloud")]
        [TestCase("tLoadC", "loadCloud")]
        public void TestCloudTool(string elementId, string res)
        {
            obj.FindElement(elementId).Click();
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }
    }
}
