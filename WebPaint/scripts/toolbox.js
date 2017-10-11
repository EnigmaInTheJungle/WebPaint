var pSimple = document.getElementById("pSimple");
var pText = document.getElementById("pText");

function setPluginActions(command) {
    pSimple.addEventListener("click", function () {
        command.setPlugin(new SimpleFigurePlugin());
    });
}