

var mNew = document.getElementById("mNew");
var mOpen = document.getElementById("mOpen");
var mSave = document.getElementById("mSave");
var mSaveAs = document.getElementById("mSaveAs");
var mSaveC = document.getElementById("mSaveC");
var mLoadC = document.getElementById("mLoadC");
var mExit = document.getElementById("mExit");
var mRename = document.getElementById("mRename");
var mClose = document.getElementById("mClose");
var mCloseAll = document.getElementById("mCloseAll");
var mDark = document.getElementById("mDark");
var mLight = document.getElementById("mLight");
var mPink = document.getElementById("mPink");
var mSimpleFigure = document.getElementById("mSimpleFigure");
var mTextFigure = document.getElementById("mTextFigure");
var mEng = document.getElementById("mEng");
var mRus = document.getElementById("mRus");
var mUkr = document.getElementById("mUkr");
var mAbout = document.getElementById("mAbout");
var mShowHelp = document.getElementById("mShowHelp");

setMenuActions(new xCommand());

function setMenuActions(command)
{
	mNew.onclick = command.addTab;
	mOpen.onclick = command.openFile;
	mSave.onclick = command.saveFile;
	mSaveAs.onclick = command.saveAsFile;
	mSaveC.onclick = command.saveCloud;
	mLoadC.onclick = command.loadCloud;
	mExit.onclick = command.exit;
	mRename.onclick = command.renameTab;
	mClose.onclick = command.closeTab;
	mCloseAll.onclick = command.closeAllTabs;
	mDark.onclick = command.changeSkin;
	mLight.onclick = command.changeSkin;
	mPink.onclick = command.changeSkin;
	mSimpleFigure.onclick = command.addPlugin;
	mTextFigure.onclick = command.addPlugin;
	mEng.onclick = command.changeLang;
	mRus.onclick = command.changeLang;
	mUkr.onclick = command.changeLang;
	mAbout.onclick = command.about;
	mShowHelp.onclick = command.showHelp;
}

