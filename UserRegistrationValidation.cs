using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    internal class UserRegistrationValidation
    {
        //UC1-validate first name
        public static void ValidateFirstName()
        {
            Console.WriteLine("Please Enter your First Name:");
            string firstName = Console.ReadLine();
            string firstName_pattern = "^[A-Z][a-z]{2,}$";

            if (Regex.IsMatch(firstName , firstName_pattern))
            {
                Console.WriteLine("First Name is Valid");
            }
            else
            {
                Console.WriteLine("First Name is not Valid");
            }
        }


        //UC2-validate last name
        public static void ValidateLastName()
        {
            Console.WriteLine("Please Enter your Last Name:");
            string lastName = Console.ReadLine();
            string lastName_pattern = "^[A-Z][a-z]{2,}$";

            if (Regex.IsMatch(lastName , lastName_pattern))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid");
            }
        }

    }
}
