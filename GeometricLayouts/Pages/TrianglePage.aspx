<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TrianglePage.aspx.cs" Inherits="GeometricLayouts.Pages.WebForm1" %>

<!DOCTYPE html>

<%--    This is a temperory page to call web apis.  --%>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test Triangle Web APIs</title>

    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"></script>    
    <script src="../Scripts/TriangleScripts.js"></script>

    <style>
        .txtCoordinateResult {width : 300px;}
        .txtCoordinate {width : 25px;}
    </style>
</head>
<body>
    <div id="dvFindCoordinates">
        <label id="lblTrianglePosition" for="txtTrianglePosition">Enter triangle position : </label>
        <input type="text" id="txtTrianglePosition" placeholder="eg: C3"/>
        <br />
        <input type="button" id="btnFindCoordinates" value="Get Coordinates" onclick="CallTriangleCoordinatesAPI()"/>
        <br />
        <label id="lblResult1" for="txtResult1">Result : </label>
        <input type="text" class="txtCoordinateResult" id="txtResult1"/>
    </div>
    <br /><br />
    <div id="dvFindPosition">
        <label id="lblTriangleCoordinates">Enter triangle coordinates : </label>
        <br />
        <label id="lblVertex1">Vertex 1 : </label>
        <input type="text" class="txtCoordinate" id="txtX1"/>
        <input type="text" class="txtCoordinate" id="txtY1"/>
        <br />
        <label id="lblVertex2">Vertex 2 : </label>
        <input type="text" class="txtCoordinate" id="txtX2"/>
        <input type="text" class="txtCoordinate" id="txtY2"/>
        <br />
        <label id="lblVertex3">Vertex 3 : </label>
        <input type="text" class="txtCoordinate" id="txtX3"/>
        <input type="text" class="txtCoordinate" id="txtY3"/>
        <br />
        <input type="button" id="btnFindPosition" value="Find Position" onclick="CallTrianglePositionAPI()"/>
        <br />
        <label id="lblResult2" for="txtResult2">Result : </label>
        <input type="text" id="txtResult2"/>
    </div>
</body>
</html>
