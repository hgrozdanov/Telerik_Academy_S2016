using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Employee_Data_test
{
    class Program
    {
        static void Main(string[] args)
        {
            /* I tried to change the Problem a little, now you can enter a name of your worker and age ofcourse up to 100,
             * you can enter sex, choosing between M or f and ID number up to 9 digits or unique number up to 20 digits.
             * Soo play with my program and make a mistakes to see what will happen.
             */

            bool check = true;
            List<object> myEmployees = new List<object>();

            Console.Write("Enter worker first name: ");
            while (check)
            {
                try
                {
                    check = false;
                    string firstName = Console.ReadLine();
                    myEmployees.Add(firstName);

                }
                catch (FormatException)
                {
                    Console.Write("Plase enter worker first name correct: ");
                    check = true;
                }
            }
            check = true;
            Console.Write("Enter worker second name: ");
            while (check)
            {
                try
                {
                    check = false;
                    string lastName = Console.ReadLine();
                    myEmployees.Add(lastName);

                }
                catch (FormatException)
                {
                    Console.Write("Plase enter worker second name correct: ");
                    check = true;
                }
            }
            check = true;
            Console.Write("Enter worker age: ");
            while (check)
            {
                try
                {
                    check = false;
                    byte age = byte.Parse(Console.ReadLine());
                    myEmployees.Add(age);

                }
                catch (FormatException)
                {
                    Console.Write("Plase enter worker age choosing number from 1 to 100: ");
                    check = true;
                }
                catch (OverflowException)
                {
                    Console.Write("Plase enter worker age choosing number from 1 to 100: ");
                    check = true;
                }
            }
            check = true;
            Console.Write("Enter worker sex: ");
            while (check)
            {
                try
                {
                    char sex = char.Parse(Console.ReadLine());
                    if (sex == 'M' || sex == 'm' || sex == 'F' || sex == 'f')
                    {
                        check = false;
                        myEmployees.Add(sex);
                    }
                    else
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.Write("M for male or F for female: ");
                    check = true;
                }
            }
            check = true;
            Console.Write("Enter worker ID number: ");
            while (check)
            {
                try
                {
                    long IDnumber = long.Parse(Console.ReadLine());
                    if (IDnumber < 100000000)
                    {
                        throw new FormatException();
                    }
                    if (IDnumber < 1000000000)
                    {
                        check = false;
                        myEmployees.Add(IDnumber);
                    }
                    else
                    {
                        throw new OverflowException();
                    }
                }
                catch (FormatException)
                {
                    Console.Write("You should use only 9 digits: ");
                    check = true;
                }
                catch (OverflowException)
                {
                    Console.Write("ID number should be long 9 digits: ");
                    check = true;
                }
            }
            check = true;
            Console.Write("Enter worker Unique number: ");
            while (check)
            {
                try
                {
                    check = false;
                    ulong uniqueNum = ulong.Parse(Console.ReadLine());
                    myEmployees.Add(uniqueNum);

                }
                catch (FormatException)
                {
                    Console.Write("You should use only digits: ");
                    check = true;
                }
                catch (OverflowException)
                {
                    Console.Write("Unique worker number should be long up to 20 digits: ");
                    check = true;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Thank you!!!");
            Console.Write("Please wait it is loading");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.Write(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(".");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine();

            for (int i = 0; i < myEmployees.Count; i++)
            {
                Console.WriteLine(myEmployees[i]);
                Console.Write("Type: ");
                Console.WriteLine(myEmployees[i].GetType());
                Console.WriteLine();
            }

        }
    }
}
