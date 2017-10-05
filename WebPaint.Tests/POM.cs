using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebPaintAutoTests
{
    public class POM
    {
        By mNew = By.Id("mNew");
        By mOpen = By.Id("mOpen");
        By mSave = By.Id("mSave");
        By mSaveAs = By.Id("mSaveAs");
        By mSaveCloud = By.Id("mSaveC");
        By mLoadCloud = By.Id("mLoadC");
        By mExit = By.Id("mExit");
        By mRename = By.Id("mRename");
        By mClose = By.Id("mClose");
        By mCloseAll = By.Id("mCloseAll");
        By mDark = By.Id("mDark");
        By mLight = By.Id("mLight");
        By mPink = By.Id("mPink");
        By mSimpleFigure = By.Id("mSimpleFigure");
        By mTextFigure = By.Id("mTextFigure");
        By mEng = By.Id("mEng");
        By mRus = By.Id("mRus");
        By mUkr = By.Id("mUkr");
        By mAbout = By.Id("mAbout");
        By mShowHelp = By.Id("mShowHelp");

        By tNew = By.Id("tNew");
        By tClose = By.Id("tClose");
        By tCloseAll = By.Id("tCloseAll");
        By tSave = By.Id("tSave");
        By tLoad = By.Id("tLoad");
        By tSaveC = By.Id("tSaveC");
        By tLoadC = By.Id("tLoadC");

        IWebDriver driver;
        public POM(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement FindElement(string s)
        {
            IWebElement flag = null;
            switch (s)
            {
                case "mNew":
                    flag = driver.FindElement(mNew);
                    break;
                case "mOpen":
                    flag = driver.FindElement(mOpen);
                    break;
                case "mSave":
                    flag = driver.FindElement(mSave);
                    break;
                case "mSaveAs":
                    flag = driver.FindElement(mSaveAs);
                    break;
                case "mSaveCloud":
                    flag = driver.FindElement(mSaveCloud);
                    break;
                case "mLoadCloud":
                    flag = driver.FindElement(mLoadCloud);
                    break;
                case "mExit":
                    flag = driver.FindElement(mExit);
                    break;
                case "mRename":
                    flag = driver.FindElement(mRename);
                    break;
                case "mClose":
                    flag = driver.FindElement(mClose);
                    break;
                case "mCloseAll":
                    flag = driver.FindElement(mCloseAll);
                    break;
                case "mDark":
                    flag = driver.FindElement(mDark);
                    break;
                case "mLight":
                    flag = driver.FindElement(mLight);
                    break;
                case "mPink":
                    flag = driver.FindElement(mPink);
                    break;
                case "mSimpleFigure":
                    flag = driver.FindElement(mSimpleFigure);
                    break;
                case "mTextFigure":
                    flag = driver.FindElement(mTextFigure);
                    break;
                case "mEng":
                    flag = driver.FindElement(mEng);
                    break;
                case "mRus":
                    flag = driver.FindElement(mRus);
                    break;
                case "mUkr":
                    flag = driver.FindElement(mUkr);
                    break;
                case "mAbout":
                    flag = driver.FindElement(mAbout);
                    break;
                case "mShowHelp":
                    flag = driver.FindElement(mShowHelp);
                    break;
                case "tNew":
                    flag = driver.FindElement(tNew);
                    break;
                case "tClose":
                    flag = driver.FindElement(tClose);
                    break;
                case "tCloseAll":
                    flag = driver.FindElement(tCloseAll);
                    break;
                case "tSave":
                    flag = driver.FindElement(tSave);
                    break;
                case "tLoad":
                    flag = driver.FindElement(tLoad);
                    break;
                case "tSaveC":
                    flag = driver.FindElement(tSaveC);
                    break;
                case "tLoadC":
                    flag = driver.FindElement(tLoadC);
                    break;
                default:
                    break;
            }
            return flag;
        }
    }
}
