using System;

namespace HW09Exchange_Variable_Values
{
    class Program
    {
        static void Main()
        {
            //Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. 
            //Print the variable values before and after the exchange.


            //Temp third value method
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Before:\na = {0}\nb = {1}",a,b);
            
            int c = b;
            b = a;
            a = c;
            Console.WriteLine("After:\na ={0}\nb = {1}", a, b);


            //Exchanging placeholders method
            //int t = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //
            //Console.WriteLine("Before:");
            //Console.WriteLine("t = {0}", t);
            //Console.WriteLine("y = {0}", y);
            //Console.WriteLine("After:");
            //Console.WriteLine("t = {0}",y);
            //Console.WriteLine("y = {0}", t);


            //And found a third matematical method..
            //int r = int.Parse(Console.ReadLine());
            //int e = int.Parse(Console.ReadLine());
            //Console.WriteLine("Before:");
            //Console.WriteLine("r = {0}", r);
            //Console.WriteLine("e = {0}", e);
            //
            //r = r + e;
            //e = r - e;
            //r = r - e;
            //
            //Console.WriteLine("After;");
            //Console.WriteLine("r = {0}", r);
            //Console.WriteLine("e = {0}", e);
        }
    }
}


