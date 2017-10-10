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
    if (e.buttons === 1) {

        var figure = new Figure(new Point(x, y), new Point(e.offsetX, e.offsetY), new Data());
        if (svg.childElementCount > 0 && isDrawingStarted === true) {
            svg.removeChild(svg.lastChild);
        }
        isDrawingStarted = true;
        svg.appendChild(figure.getPath());
    }
}

function finishDrawing(e) {
    var figure = new Figure(new Point(x, y), new Point(e.offsetX, e.offsetY), new Data());
    svg.appendChild(figure.getPath());
    isDrawingStarted = false;
}

