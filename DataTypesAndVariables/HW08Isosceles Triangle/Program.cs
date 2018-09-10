using System;

namespace HW08Isosceles_Triangle
{
    class Program
    {
        static void Main()
        {
            char ch = '\u0040';

            string result = "\t\t\t@\n\n\t\t@\t\t@\n\n\t@\t\t\t\t@\n\n@\t\t@\t\t@\t\t@";

            string result1 = @"             @

        @       @

    @               @

@       @       @       @

########################################################################
This is the menu where you can find useful informantion about our product
Btw adding a single quote symbol here '
########################################################################";

            string separator = "\n########################################################################" +
                "\n This is the menu where you can find useful informantion about our product" +
                "\n Btw adding a single quote symbol here \'" +
                "\n########################################################################";

            string more = "\nAssign \\backslash\\ symbol\n\n";
            Console.WriteLine(result + separator + more);
            Console.WriteLine(result1);
        }
    }
}
