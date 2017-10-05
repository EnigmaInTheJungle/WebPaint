using Microsoft.VisualStudio.TestTools.UnitTesting;
using JSTest;
using JSTest.ScriptLibraries;

namespace WebPaintAutoTests
{
    [TestClass]
    public class UnitLogicTestJS
    {
        static private readonly TestScript _commonTestScript = new TestScript();

        [ClassInitialize]
        static public void CommonJavaScriptTests(TestContext tc)
        {
            _commonTestScript.AppendFile(@"E:\ORT_1708\Team\WebPaint\WebPaint\scripts\ucommand.js");
            _commonTestScript.AppendBlock(new JsAssertLibrary());
        }

        [DataTestMethod]
        [DataRow("addTab")]
        [DataRow("closeTab")]
        [DataRow("closeAllTabs")]
        [DataRow("saveFile")]
        [DataRow("openFile")]
        [DataRow("saveAsFile")]
        [DataRow("saveCloud")]
        [DataRow("loadCloud")]
        [DataRow("renameTab")]
        [DataRow("changeSkin")]
        [DataRow("changeLang")]
        [DataRow("addPlugin")]
        [DataRow("showHelp")]
        [DataRow("exit")]
        public void TestCalcJs(string res)
        {
            _commonTestScript.RunTest($"assert.equal('{res}', new uCommand().{res}());");
        }
    }
}