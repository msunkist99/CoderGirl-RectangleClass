using System;

namespace RectangleClass
{
    public class Rectangle
    {

        public int length { get; set; }
        public int width { get; set; }

        public Rectangle()
        {
            length = 0;
            width = 0;
        }

        public double GetRectangleArea()
        {
            return length * width;
        }

        public double GetRectanglePerimeter()
        {
            return (length * 2) + (width * 2);
        }

        public bool IsRectangleASquare()
        {
            /*
            if (length == width)
            {
                return true;
            }
            else
            {
                return false;
            }
            */

            return length == width ? true : false;
        }
    }
}

