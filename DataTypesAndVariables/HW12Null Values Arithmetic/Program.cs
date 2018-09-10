using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW12Null_Values_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
                new string('-', 40) +
                "\nExample with integer\n" +
                new string('-', 40));

            int? baseInteger = null;
            //int someInteger = null;
            Console.WriteLine(
                "This is the integer with Null value -> " + baseInteger);
            baseInteger = 5;
            Console.WriteLine(
                "This is the integer with value 5 -> " + baseInteger);


            Console.WriteLine(
                new string('-', 40) +
                "\nExample with double\n" +
                new string('-', 40));

            double? dDouble;
            //double someDouble;
            dDouble = null;
            Console.WriteLine(
                "This is the double with Null value -> " + dDouble);
            dDouble = dDouble + 2.5;
            dDouble = dDouble * 2.5;
            Console.WriteLine(
                "This is adding the with value of 2.5 to dDouble(null) -> " + dDouble + "\n" + "As we see nothing happens.. you can't add or substract from \'null\'");

            int? value = null;
            Console.WriteLine(value.GetValueOrDefault());
        }
    }
}
