/* JavaScript för bildspel;  */
/* Flera olika böcker visas i en evig loop; */

var fart = 3000;
var Bild = new Array();

for (i = 0; i < 32; i++)
    Bild[i] = '../bilder/bok' + i + '.jpg';

var f;
var a = 0;
var b = Bild.length;

var laddaBild = new Array();
for (i = 0; i < b; i++) {
    laddaBild[i] = new Image(height = 227, width = 193);
    laddaBild[i].src = Bild[i];
}

function startBildspel() {
    document.images.Bildspel.src = laddaBild[a].src;
    a = a + 1;
    if (a > (b - 1)) a = 0;
    f = setTimeout('startBildspel()', fart);
}

window.onload = startBildspel;
