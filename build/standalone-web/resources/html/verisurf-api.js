// The intervalrate in ms
var refreshRate = 25;

// This can be toggled in the console to output debug info
var debug = false;

// HTML element variables
var verisurf_x = $("#x_measured");
var verisurf_y = $("#y_measured");
var verisurf_z = $("#z_measured");
var verisurf_dx = $("#x_deviation");
var verisurf_dy = $("#y_deviation");
var verisurf_dz = $("#z_deviation");
var verisurf_d3 = $("#d3_measured");
var verisurf_px = $("#x_nominal");
var verisurf_py = $("#y_nominal");
var verisurf_pz = $("#z_nominal");

var refreshInput = $("#refresh-input");

// other variables
var deviceID = 0;
var websocket;
var timer;

// Function called when dropdown is changed
function setDevice(id) {
    deviceID = id;
}

// Updates refresh rate
refreshInput.keyup(function () {
    var value = parseInt(this.value);
    if (isNaN(value) && this.value != "")
        refreshInput.css("color", "#F44336");
    else
        refreshInput.css("color", "white");

    refreshRate = value;
    console.log(refreshRate);
});

function sendCommand(command) {
    websocket.send("<" + command + " />\n");
    console.log("Command: " + command);
}

// Sends command to retrieve current device info
function socketTimerCallback() {
    websocket.send("<device_info id='" + deviceID + "' />\n");
    console.log("fire");
    setTimeout(socketTimerCallback, refreshRate);
}

// Checks if the current value is zero or null
function ifNullZero(value) {
    if (value == null)
        return "0.0000";
    else
        return parseFloat(value).toFixed(4);
}

$(function () {
    websocket = new WebSocket("ws://localhost:6734");

    websocket.onopen = function (event) {
        websocket.send("<device_list />\n");
        timer = setTimeout(socketTimerCallback, refreshRate);
    };

    websocket.onmessage = function (event) {
        var domparser = new DOMParser();
        var xmlDoc = domparser.parseFromString(event.data, "text/xml");
        var info = xmlDoc.getElementsByTagName("device_info");
        if (info.length > 0) {
            verisurf_x.text(ifNullZero(info[0].getAttribute("X")));
            verisurf_px.text(ifNullZero(info[0].getAttribute("PX")));
            verisurf_dx.text(ifNullZero(info[0].getAttribute("DX")));

            verisurf_y.text(ifNullZero(info[0].getAttribute("Y")));
            verisurf_py.text(ifNullZero(info[0].getAttribute("PY")));
            verisurf_dy.text(ifNullZero(info[0].getAttribute("DY")));

            verisurf_z.text(ifNullZero(info[0].getAttribute("Z")));
            verisurf_pz.text(ifNullZero(info[0].getAttribute("PZ")));
            verisurf_dz.text(ifNullZero(info[0].getAttribute("DZ")));

            verisurf_d3.text(ifNullZero(info[0].getAttribute("D3")));
        }
        var deviceList = xmlDoc.getElementsByTagName("device_list");
        if (deviceList.length > 0) {
            var devices = deviceList[0].getElementsByTagName("device");
            for (var i = 0; i < devices.length; i++) {
                var elem = $("#settings-menu").children().eq(i + 3);
                console.log(elem);
                var name = devices[i].getAttribute("name");
                if (name == "")
                    elem.hide();
                else
                    elem.show().html('<a href="#" onclick="setDevice(' + i + ')"><i class="fa fa-exchange"></i> ' + name + ' </a>');
            }
        }
        if (debug)
            console.log(event.data);
    };

    websocket.onclose = function (event) {
        clearTimeout(timer);
    };
});
