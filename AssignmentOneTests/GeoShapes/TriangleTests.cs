using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOne.GeoShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne.GeoShapes.Tests
{
    [TestClass()]
    public class TriangleTests
    {

        [TestMethod()]
        [DataRow(8,6.93f)]
        [DataRow(-3, 0)]
        [DataRow(0, 0)]
        public void GetAreaTest(float area, float expected)
        {
            var triangle = new Triangle(area);
            var actual = triangle.GetArea();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        [DataRow(8, 24)]
        [DataRow(0, 0)]
        [DataRow(-3, 0)]
        public void GetPerimeterTest(float perimeter, float expected)
        {
            var triangle = new Triangle(perimeter);
            var actual = triangle.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

    }
}