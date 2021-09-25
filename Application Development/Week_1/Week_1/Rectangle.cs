using System;

namespace Week_1
{
    // Defining a Class
    class Rectangle
    {
        public double length;
        public double width;

        // Constructor
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }


        public double GetArea()
        {
            return length * width;
        }

        // Properties:
        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                {
                    length = value;
                }
            }
        }
    }
}
