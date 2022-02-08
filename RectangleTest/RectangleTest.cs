using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnitDemonstration;
using NUnit.Framework;

namespace Assignment2_Test
{
    [TestFixture]
    public class RectangleTest
    {
        //For GetLength Method
        [Test]
        public void InvalidRectangle_GetLength_Zero()
        {   
            int length = 0;
            int width = 30;

            string expected = "The length is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetLength();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_GetLength_LessThanZero()
        {
            int length = -10;
            int width = 30;

            string expected = "The length is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetLength();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_GetLength()
        {
            int length = 10;
            int width = 30;

            string expected = "The length is valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetLength();
            Assert.AreEqual(expected, actual);
        }

        //For SetLength Method
        [Test]
        public void InvalidRectangle_SetLength_Zero()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setLength = 0;

            string expected = "The length is NOT valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetLength(setLength);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_SetLength_LessThanZero()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setLength = -20;

            string expected = "The length is NOT valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetLength(setLength);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_SetLength()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setLength = 30;

            string expected = "The length is valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetLength(setLength);
            Assert.AreEqual(expected, actual);
        }

        //For GetWidth Method
        [Test]
        public void InvalidRectangle_GetWidth_Zero()
        {
            int length = 30;
            int width = 0;

            string expected = "The width is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetWidth();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_GetWidth_LessThanZero()
        {
            int length = 30;
            int width = -10;

            string expected = "The width is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetWidth();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_GetWidth()
        {
            int length = 50;
            int width = 30;

            string expected = "The width is valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetWidth();
            Assert.AreEqual(expected, actual);
        }

        //For SetWidth Method
        [Test]
        public void InvalidRectangle_SetWidth_Zero()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setWidth = 0;

            string expected = "The width is NOT valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetWidth(setWidth);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_SetWidth_LessThanZero()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setWidth = -30;

            string expected = "The width is NOT valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetWidth(setWidth);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_SetWidth()
        {
            int initialLength = 1;
            int initialWidth = 1;
            int setWidth = 50;

            string expected = "The width is valid.";
            Rectangle rectangle = new Rectangle(initialLength, initialWidth);
            string actual = rectangle.TestSetWidth(setWidth);
            Assert.AreEqual(expected, actual);
        }

        //For GetPerimeter Method
        [Test]
        public void InvalidRectangle_GetPerimeter_Two()
        {
            int length = 0;
            int width = 1;

            string expected = "The perimeter is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_GetPerimeter_LessThanTwo()
        {
            int length = -1;
            int width = 0;

            string expected = "The perimeter is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_GetPerimeter()
        {
            int length = 1;
            int width = 1;

            string expected = "The perimeter is valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetPerimeter();
            Assert.AreEqual(expected, actual);
        }
        //For GetArea Method
        [Test]
        public void InvalidRectangle_GetArea_Zero()
        {
            int length = 0;
            int width = 1;

            string expected = "The area is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetArea();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void InvalidRectangle_GetArea_LessThan_Zero()
        {
            int length = 0;
            int width = 0;

            string expected = "The area is NOT valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetArea();
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void ValidRectangle_GetArea()
        {
            int length = 1;
            int width = 1;

            string expected = "The area is valid.";
            Rectangle rectangle = new Rectangle(length, width);
            string actual = rectangle.TestGetArea();
            Assert.AreEqual(expected, actual);
        }

    }
}
