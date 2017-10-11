
function xCommand()
{
    this.data = null;
    this.plugin = null;
}

xCommand.prototype.addTab = function()
{
	alert("addTab");
};

xCommand.prototype.closeTab = function()
{
	alert("closeTab");
};

xCommand.prototype.closeAllTabs = function()
{
	alert("closeAllTabs");
};

xCommand.prototype.saveFile = function()
{
	alert("saveFile");
};

xCommand.prototype.openFile = function()
{
	alert("openFile");
};

xCommand.prototype.saveAsFile = function()
{
	alert("saveAsFile");
};

xCommand.prototype.saveCloud = function()
{
	alert("saveCloud");
};

xCommand.prototype.loadCloud = function()
{
	alert("loadCloud");
};

xCommand.prototype.renameTab = function()
{
	alert("renameTab");
};

xCommand.prototype.changeSkin = function()
{
	alert("changeSkin");
};

xCommand.prototype.changeLang = function()
{
	alert("changeLang");
};

xCommand.prototype.addPlugin = function()
{
	alert("addPlugin");
};

xCommand.prototype.about = function()
{
	alert("about");
};

xCommand.prototype.showHelp = function()
{
	alert("showHelp");
};

xCommand.prototype.exit = function()
{
	alert("exit");
};

xCommand.prototype.setPlugin = function (plugin) {
    if (this.plugin === null || this.plugin.name !== plugin.name) {
        this.plugin = plugin;
        this.data = plugin.data;
        plugin.addToolBar();
    }
};
