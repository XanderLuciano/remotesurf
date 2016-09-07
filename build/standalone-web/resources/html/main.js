// HTML Elements
var body = $("body");
var menu = $("#menu-wrapper");
var content = $("#content-wrapper");

// Menu Items
var menuButon = $(".menu-button");
var toggleBg = $("#toggle-background");
var refresh = $("#refresh-button");

// Hide menu if we click anywhere besides the menu
content.click(function () {
    if (this.id != "show-menu-button")
        toggleMenu();
});

// Toggle dropdown sub-menu
menuButon.click(function () {
    $(this).siblings(".sub-menu").toggleClass("show");
    $(".fa-chevron-up", this).toggleClass("rotate-180");
});

// Refresh button spinner
refresh.click(function () {
    var icon = $(".fa", this);
    icon.addClass("fa-spin");
    setTimeout(function () {
        icon.removeClass("fa-spin");
    }, 2000);
    sendCommand("device_list");
});

// Toggle offcanvas menu
function toggleMenu() {
    menu.toggleClass("show-menu");
    content.toggleClass("show-menu");
}

// Toggle background image
toggleBg.click(function () {
    body.toggleClass("no-image");
});

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