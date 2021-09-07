using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison_Refactor
{
    public class Length
    {
        public static void check()
        {
            int x1, x2, y1, y2;
            double length_One;
            x1 = 4;
            y1 = 1;
            x2 = 1;
            y2 = 3;

            int resultone = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            length_One = Math.Abs((0.5) * resultone);
            Console.WriteLine("Length Of the coordinates ({0},{1}) and ({2},{3}) is : {4}", x1, y1, x2, y2, length_One);
        }
        
    }
}
