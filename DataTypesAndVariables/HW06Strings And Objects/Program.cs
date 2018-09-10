using System;

namespace HW06Strings_And_Objects
{
    class Program
    {
        static void Main()
        {
            string hello = "Hello";
            string world = "World";

            object myObject = (hello + " " + world);

            string helloWorld = string.Format("This is {0} application",myObject);

            Console.WriteLine(helloWorld);
        }
    }
}
