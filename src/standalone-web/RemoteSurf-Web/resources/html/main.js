// HTML Elements
var menu = $("#menu-wrapper");
var content = $(".content-wrapper");

// Menu Items
var measure = $("#measure");
var measureMenu = $(".measure-menu");
var cadview = $("#cadview");
var cadviewMenu = $(".cadview-menu");
var settings = $("#settings");
var settingsMenu = $(".settings-menu");

var isShown = false;

content.click(function (e) {
    if (isShown && e.target.id != "menu-button") {
        toggleMenu();
    }
});

measure.click(function () {
    if (measureMenu.hasClass("show")) {
        measureMenu.removeClass("show");
        measure.children(".fa-chevron-up").removeClass("rotate-180");
    }
    else {
        measureMenu.addClass("show");
        measure.children(".fa-chevron-up").addClass("rotate-180");
    }
});

cadview.click(function () {
    if (cadviewMenu.hasClass("show")) {
        cadviewMenu.removeClass("show");
        cadview.children(".fa-chevron-up").removeClass("rotate-180");
    }
    else {
        cadviewMenu.addClass("show");
        cadview.children(".fa-chevron-up").addClass("rotate-180");
    }
});

settings.click(function () {
    if (settingsMenu.hasClass("show")) {
        settingsMenu.removeClass("show");
        settings.children(".fa-chevron-up").removeClass("rotate-180");
    }
    else {
        settingsMenu.addClass("show");
        settings.children(".fa-chevron-up").addClass("rotate-180");
    }
});

function toggleMenu() {
    if (!isShown) {
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