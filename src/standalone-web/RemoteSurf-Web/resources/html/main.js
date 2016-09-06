// HTML Elements
var menu = $("#menu-wrapper");
var content = $(".content-wrapper");

var isShown = false;

content.click(function(e) {
    if(isShown && e.target.id != "menu-button"){
        toggleMenu();
        console.log("hiding menu");
        console.log(e.target.id);
    }
});

function toggleMenu(){
    if (!isShown){
        menu.addClass("show-menu");
        content.addClass("show-menu");
    }
    else {
        menu.removeClass("show-menu");
        content.removeClass("show-menu");
    }

    isShown = !isShown;
}

function toggleFullScreen() {
    if ((document.fullScreenElement && document.fullScreenElement !== null) ||
        (!document.mozFullScreen && !document.webkitIsFullScreen)) {
        if (document.documentElement.requestFullScreen) {
            document.documentElement.requestFullScreen();
        } else if (document.documentElement.mozRequestFullScreen) {
            document.documentElement.mozRequestFullScreen();
        } else if (document.documentElement.webkitRequestFullScreen) {
            document.documentElement.webkitRequestFullScreen(Element.ALLOW_KEYBOARD_INPUT);
        }
    } else {
        if (document.cancelFullScreen) {
            document.cancelFullScreen();
        } else if (document.mozCancelFullScreen) {
            document.mozCancelFullScreen();
        } else if (document.webkitCancelFullScreen) {
            document.webkitCancelFullScreen();
        }
    }
}