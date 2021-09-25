using System;
using System.Collections.Generic;
using System.Text;

namespace Week_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);
            rect.Length = 22.0;
            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}
