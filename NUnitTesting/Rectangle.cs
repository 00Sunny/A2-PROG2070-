using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public class Rectangle
    {
        private int length;
        private int width;

        public Rectangle()
        {
            length = 1;
            width = 1;
        }

        public Rectangle (int inputLength, int inputWidth)
        {
            this.length = inputLength;
            this.width = inputWidth;
        }

        public int GetLength()
        {            
            return length;
        }

        public int SetLength(int length)
        {
            this.length = length;
            return length;
        }

        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return width;
        }

        public int GetPerimeter()
        {
            return 2 * length + 2 * width;
        }

        public int GetArea()
        {
            return length * width;
        }

        public string TestGetLength()
        {
            string result = "";
            if (length == 0)
            {
                result = "The length is NOT valid.";
            }
            else if(length < 0)
            {
                result = "The length is NOT valid.";
            }
            else
            {
                result = "The length is valid.";
            }
            return result;
        }

        public string TestSetLength(int inputLength)
        {
            this.length = inputLength;
            string result = "";
            if (length == 0)
            {
                result = "The length is NOT valid.";
            }
            else if (length < 0)
            {
                result = "The length is NOT valid.";
            }
            else
            {
                result = "The length is valid.";
            }
            return result;
        }

        public string TestGetWidth()
        {
            string result = "";
            if (width == 0)
            {
                result = "The width is NOT valid.";
            }
            else if (width < 0)
            {
                result = "The width is NOT valid.";
            }
            else
            {
                result = "The width is valid.";
            }
            return result;
        }

        public string TestSetWidth(int inputWidth)
        {
            this.width = inputWidth;
            string result = "";
            if (width == 0)
            {
                result = "The width is NOT valid.";
            }
            else if (width < 0)
            {
                result = "The width is NOT valid.";
            }
            else
            {
                result = "The width is valid.";
            }
            return result;
        }

        public string TestGetPerimeter()
        {
            string result = "";
            if(2 * length + 2 * width == 2)
            {
                result = "The perimeter is NOT valid.";
            }
            else if(2 * length + 2 * width < 2)
            {
                result = "The perimeter is NOT valid.";
            }
            else
            {
                result = "The perimeter is valid.";
            }
            return result;
        }

        public string TestGetArea()
        {
            string result = "";
            if(length * width == 0)
            {
                result = "The area is NOT valid.";
            }
            else if (length * width < 0)
            {
                result = "The area is NOT valid.";
            }
            else
            {
                result = "The area is valid.";
            }

            return result;
        }

    }
}
