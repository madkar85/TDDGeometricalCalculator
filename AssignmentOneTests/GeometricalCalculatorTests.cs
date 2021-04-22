using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOne;
using System;
using System.Collections.Generic;
using System.Text;
using AssignmentOne.Interfaces;
using AssignmentOne.GeoShapes;

namespace AssignmentOne.Tests
{
    [TestClass()]
    public class GeometricalCalculatorTests
    {
        [TestMethod()]
        public void GetPerimeterTest()
        {
            var geoThingsTest = new IGeometricalThings[]
            {
               new Triangle (5),
               new Square(10),
               new Circle(2)
            };
            var geoCal = new GeometricalCalculator();

           
            var actual = geoCal.GetPerimeter(geoThingsTest);
            var expected = 67.57f;
            Assert.AreEqual(expected, actual);
        }

        /*
        [TestMethod()]
        public void GetPerimeterTest_null()
        {
            var geoThingsTest = new IGeometricalThings[]
            {
                null
            };
            var geoCal = new GeometricalCalculator();


            var actual = geoCal.GetPerimeter(geoThingsTest);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }*/

        [TestMethod()]
        public void GetPerimeterTest_0()
        {
            var geoThingsTest = new IGeometricalThings[]
            {
               new Triangle (5),
               new Square(0),
               new Circle(2)
            };
            var geoCal = new GeometricalCalculator();


            var actual = geoCal.GetPerimeter(geoThingsTest);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest__1()
        {
            var geoThingsTest = new IGeometricalThings[]
            {
               new Triangle (5),
               new Square(2),
               new Circle(-1)
            };
            var geoCal = new GeometricalCalculator();


            var actual = geoCal.GetPerimeter(geoThingsTest);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}