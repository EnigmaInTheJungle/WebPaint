var FType = {
    RECT: 0,
    LINE: 1,
    RRECT: 2,
    ELLIPSE: 3,
};

var svgNS = "http://www.w3.org/2000/svg";

function Data() {
    this.color = "#000000";
    this.width = 1;
    this.type = FType.RECT;
}

function Point(x, y) {
    this.x = x;
    this.y = y;
}

function Figure(start, end, data) {
    this.start = new Point(Math.min(start.x, end.x), Math.min(start.y, end.y));
    this.end = new Point(Math.max(start.x, end.x), Math.max(start.y, end.y));
    this.width;
    this.height;
    this.data = data;
    this.setSize();
}


Figure.prototype.getPath = function () {

    var currentPath = document.createElementNS(svgNS, 'path');
    currentPath.setAttributeNS(null, 'stroke', this.data.color);
    currentPath.setAttributeNS(null, 'stroke-width', this.data.width);
    currentPath.setAttributeNS(null, 'fill', 'none');
    currentPath.setAttributeNS(null, "d", SVGConstructor(this.start, this.width, this.height));
    var path = new Path2D();
    return currentPath;
};

Figure.prototype.setSize = function () {
    this.width = Math.abs(this.end.x - this.start.x);
    this.height = Math.abs(this.end.y - this.start.y); 

    
};

function SVGConstructor(start, width, height) {
    return "M" + start.x + " " + start.y +
        " h" + width +
        " v" + height +
        " h" + -1 * width + " Z";
}