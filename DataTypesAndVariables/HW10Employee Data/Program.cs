using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW10Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeFirstName = "Samuel";
            string employeeLastName = "Jackson";
            byte age = 59;
            char gender = 'f';
            long personalID = 8304159853;
            int employeeNumber = 27883311;
            Console.WriteLine(@"        Employe

First name: {0}
Last name: {1}
Age: {2}
Gender: {3}
Personal ID: {4}
Employee Number: {5}", employeeFirstName, employeeLastName, age, gender, personalID, employeeNumber);


        }
    }
}
