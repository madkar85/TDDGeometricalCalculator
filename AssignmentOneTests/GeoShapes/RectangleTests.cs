using Microsoft.VisualStudio.TestTools.UnitTesting;
using AssignmentOne.GeoShapes;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOne.GeoShapes.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void GetAreaTest_5_3()
        {
            var rectangle = new Rectangle(5, 3);
            var actual = rectangle.GetArea();
            var expected = 15;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest_0_0()
        {
            var rectangle = new Rectangle(0, 0);
            var actual = rectangle.GetArea();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest_2_3()
        {
            var rectangle = new Rectangle(2, 3);
            var actual = rectangle.GetArea();
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTest__2__3()
        {
            var rectangle = new Rectangle(-2, -3);
            var actual = rectangle.GetArea();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void GetPerimeterTest_3_2()
        {
            var rectangle = new Rectangle(3.25f, 2.33f);
            var actual = rectangle.GetPerimeter();
            var expected = 11.16f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_12_6()
        {
            var rectangle = new Rectangle(12.87f , 6.26f);
            var actual = rectangle.GetPerimeter();
            var expected = 38.26f;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_0_0()
        {
            var rectangle = new Rectangle(0, 0);
            var actual = rectangle.GetPerimeter();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTest_0_4()
        {
            var rectangle = new Rectangle(0, 4);
            var actual = rectangle.GetPerimeter();
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
    }
}