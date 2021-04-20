using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOne.GeoShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne.GeoShapes.Tests
{
    [TestClass()]
    public class CircleTests
    {

        [TestMethod()]
        public void GetAreaTest_0()
        {
            var circle = new Circle(0);
            var actual = circle.GetArea();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetAreaTest_7()
        {
            var circle = new Circle(7);
            var actual = circle.GetArea();
            var expected = 153.94f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest_7_3()
        {
            var circle = new Circle(7.3f);
            var actual = circle.GetArea();
            var expected = 167.42f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest__1()
        {
            var circle = new Circle(-1);
            var actual = circle.GetArea();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetPerimeterTest_7_3()
        {
            var circle = new Circle(7.3f);
            var actual = circle.GetPerimeter();
            var expected = 45.87f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_2()
        {
            var circle = new Circle(2);
            var actual = circle.GetPerimeter();
            var expected = 12.57f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest__3()
        {
            var circle = new Circle(-3);
            var actual = circle.GetPerimeter();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_0()
        {
            var circle = new Circle(0);
            var actual = circle.GetPerimeter();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}