using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW11Bank_Account_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            object bankAccount;

            string holderFirstName = "Peter";
            string holderMidName = "the Mad";
            string holderLastName = "Maddsen";

            decimal balance = 2420.32m;
            string bankName = "Allianz";
            string IBAN = "BG17 DHSH 3030 2114 3221 18";
            long cardNumber1 = 349020305010013;
            long cardNumber2 = 349025812666413;
            long cardNumber3 = 343846153205443;

            bankAccount = "First name: " + holderFirstName + "\n" + "Middle name: " + holderMidName + "\n" + "Last name: " + holderLastName + "\n" + "Balance: " + balance + "\n" + "Bank name: " + bankName 
                + "\n" + "IBAN: " + IBAN + "\n" + "Visa Electron: " + cardNumber1 + "\n" + "Visa Classic: " + cardNumber2 + "\n" + "Visa gold: " + cardNumber3;
            Console.WriteLine(bankAccount);
        }
    }
}
