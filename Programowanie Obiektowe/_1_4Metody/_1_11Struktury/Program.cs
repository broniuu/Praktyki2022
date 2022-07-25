using _1_11Struktury;
using System.Collections;

//App1.Start();

//App2.Start();

var pointA = new Point(0, 0);
var pointB = new Point(0, 1);
var pointC = new Point(1, 0);
var pointD = new Point(0, 20);

var lineA = new Line(pointA, pointB);
var lineB = new Line(pointB, pointC);
var lineC = new Line(pointC, pointA);

var triangle = new Triange(lineA,lineB,lineC);
Console.WriteLine(triangle.CanMakeTriangle());
