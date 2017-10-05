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
    public class MenuAutoTests
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

        [TestCase("mNew", "addTab")]
        [TestCase("mOpen", "openFile")]
        [TestCase("mSave", "saveFile")]
        [TestCase("mSaveAs", "saveAsFile")]
        [TestCase("mSaveCloud", "saveCloud")]
        [TestCase("mLoadCloud", "loadCloud")]
        [TestCase("mExit", "exit")]
        public void TestFileMenu(string elementId, string res)
        {          
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("mRename", "renameTab")]
        [TestCase("mClose", "closeTab")]
        [TestCase("mCloseAll", "closeAllTabs")]
        public void TestWindowMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("mDark", "changeSkin")]
        [TestCase("mLight", "changeSkin")]
        [TestCase("mPink", "changeSkin")]
        public void TestViewMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("mSimpleFigure", "addPlugin")]
        [TestCase("mTextFigure", "addPlugin")]
        public void TestPluginMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("mRus", "changeLang")]
        [TestCase("mEng", "changeLang")]
        [TestCase("mUkr", "changeLang")]
        public void TestLangMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }

        [TestCase("mAbout", "about")]
        [TestCase("mShowHelp", "showHelp")]
        public void TestHelpMenu(string elementId, string res)
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
            executor.ExecuteScript($"document.getElementById('{obj.FindElement(elementId).GetAttribute("id")}').click();");
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            alert.Accept();
            NUnit.Framework.Assert.AreEqual(res, alertText);
        }
    }
}
