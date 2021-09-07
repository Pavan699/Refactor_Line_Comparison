using System;

namespace Line_Comparison_Refactor
{
    //Used Inheritance concept to call the methods in Length
    class Program : Length
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Line Comparison With OOPs of C-Sharp");
            //calling the static check() method from Length Class
            check();           
        }
    }
}
