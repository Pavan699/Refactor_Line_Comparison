using System;
using System.Collections.Generic;
using System.Text;

namespace Line_Comparison_Refactor
{
    public class Length
    {
        //check method to calculate lengths of two lines
        public static void check()
        {
            Console.WriteLine("Welcome To Line Comparison Computation Program");
            //Declaring variables....
            int x1, x2, y1, y2, x3, x4, y3, y4;
            double length_One, length_Two;
            x1 = 4; x3 = 4;
            y1 = 1; y3 = 1;
            x2 = 1; x4 = 1;
            y2 = 3; y4 = 3; 

            //Logic
            int resultone = ((x2 - x1) ^ 2 + (y2 - y1) ^ 2);
            length_One = Math.Abs((0.5) * resultone);//Math.Abs() used to convert the negative to positive number
            Console.WriteLine("Length Of the coordinates ({0},{1}) and ({2},{3}) is : {4}", x1, y1, x2, y2, length_One);

            int resulttwo = ((x4 - x3) ^ 2 + (y4 - y3) ^ 2);
            length_Two = Math.Abs((0.5) * resulttwo);//You can use Math.Sqrt() method
            Console.WriteLine("Length Of the coordinates ({0},{1}) and ({2},{3}) is : {4}", x3, y3, x4, y4, length_Two);
            //Created Object of Length class to call equal() method
            Length l = new Length();
            l.equal(length_One, length_Two);//calling equal method with help of referance
            //Calling compare() Method (It is static method in same class)
            comapre(length_One, length_Two);
            
        }
        //Checking Equals() method
        public void equal(double length_One,double length_Two)
        {
            Console.WriteLine("Equals() Method : " + length_One.Equals(length_Two));
        }
        //Checking CompareTo() method
        public static void comapre(double length_One, double length_Two)
        {
            Console.WriteLine("CompareTo() Method : " + length_One.CompareTo(length_Two));
        }
    }
}
