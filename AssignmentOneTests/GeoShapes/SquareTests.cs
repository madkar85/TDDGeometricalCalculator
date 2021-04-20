using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOne.GeoShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne.GeoShapes.Tests
{
    [TestClass()]
    public class SquareTests
    {
        [TestMethod()]
        [DataRow(8,64)]
        [DataRow(-6, 0)]
        [DataRow(0, 0)]
        [DataRow(2.5f, 6.25f)]
        public void GetAreaTest(float area, float expected)
        {
            var square = new Square(area);
            var actual = square.GetArea();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [DataRow(8, 32)]
        [DataRow(-8, 0)]
        [DataRow(2.5f, 10)]
        public void GetPerimeterTest(float perimeter, float expected)
        {
            var square = new Square(perimeter);
            var actual = square.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }
    }
}