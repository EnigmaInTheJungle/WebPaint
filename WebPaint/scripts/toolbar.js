var tNew = document.getElementById("tNew");
var tClose = document.getElementById("tClose");
var tCloseAll = document.getElementById("tCloseAll");
var tSave = document.getElementById("tSave");
var tLoad = document.getElementById("tLoad");
var tSaveC = document.getElementById("tSaveC");
var tLoadC = document.getElementById("tLoadC");


setMenuActions(new xCommand());

function setMenuActions(command)
{
	tNew.onclick = command.addTab;
	tClose.onclick = command.closeTab;
	tCloseAll.onclick = command.closeAllTabs;
	tSave.onclick = command.saveFile;
	tLoad.onclick = command.openFile;
	tSaveC.onclick = command.saveCloud;
	tLoadC.onclick = command.loadCloud;
}

