
//This is a temporary javascript file that can be used to test the APIs.

self.CallTriangleCoordinatesAPI = function () {
    var position = $('#txtTrianglePosition').val();
    $.ajax({
        type: "GET",
        url: "../api/triangle/TriangleCoordinates?position=" + position,
        success: function (msg) {
            $('#txtResult1').val(msg);
        },
        error: function () {
            alert("Invalid input.");
        }
    });
};

self.CallTrianglePositionAPI = function () {
    var coordinates = "[{X:" + $('#txtX1').val() + ",Y:" + $('#txtY1').val() + "}"
        + ",{X:" + $('#txtX2').val() + ",Y:" + $('#txtY2').val() + "}"
        + ",{X:" + $('#txtX3').val() + ",Y:" + $('#txtY3').val() + "}]";

    $.ajax({
        type: "GET",
        url: "../api/triangle/TrianglePosition?coordinates=" + coordinates,
        success: function (msg) {
            $('#txtResult2').val(msg);
        },
        error: function () {
            alert("Invalid input.");
        }
    });

};