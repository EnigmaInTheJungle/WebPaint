var svg = document.getElementById("tablet");

svg.onmousedown = startDrawing;
svg.onmousemove = Drawing;
svg.onmouseup = finishDrawing;

var x;
var y;
var isDrawingStarted = false;


function startDrawing(e) {
    x = e.offsetX;
    y = e.offsetY;
}
function Drawing(e) {
    if (e.buttons === 1 && xcommand.plugin !== null) {
        xcommand.plugin.figure = new Figure(new Point(x, y), new Point(e.offsetX, e.offsetY), xcommand.data);
        if (svg.childElementCount > 0 && isDrawingStarted === true) {
            svg.removeChild(svg.lastChild);
        }
        isDrawingStarted = true;
        svg.appendChild(xcommand.plugin.figure.getPath());
    }
}

function finishDrawing(e) {
    if (xcommand.plugin !== null) {
        xcommand.plugin.figure = new Figure(new Point(x, y), new Point(e.offsetX, e.offsetY), xcommand.data);
        svg.appendChild(xcommand.plugin.figure.getPath());
        isDrawingStarted = false;
    }
}

