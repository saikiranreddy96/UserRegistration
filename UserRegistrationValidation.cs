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

            if (Regex.IsMatch(firstName, firstName_pattern))
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

            if (Regex.IsMatch(lastName, lastName_pattern))
            {
                Console.WriteLine("Last Name is Valid");
            }
            else
            {
                Console.WriteLine("Last Name is not Valid");
            }
        }


        //UC3-validate email id
        public static void ValidateEmail()
        {
            Console.WriteLine("Please Enter your Email-ID:");
            string email = Console.ReadLine();
            string email_pattern = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            if (Regex.IsMatch(email, email_pattern))
            {
                Console.WriteLine("Email is Valid");
            }
            else
            {
                Console.WriteLine("Email is not Valid");
            }

        }

        //UC4-validate mobile number
        public static void ValidateMobileNumber()
        {
            Console.WriteLine("\nPlease Enter your Mobie Number:");
            string mobileNumber = Console.ReadLine();
            string mobileNumber_pattern = "^[+]?91[ -][1-9][0-9]{9}$";

            if (Regex.IsMatch(mobileNumber, mobileNumber_pattern))
            {
                Console.WriteLine("Mobie Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobie Number is not Valid");
            }
        }

        //validate password
        public static void ValidatePassword()
        {
            Console.WriteLine("\nPlease Enter your Password:");
            string password = Console.ReadLine();
            //string password_pattern = "^[a-zA-Z0-9-+_!@#$%^&*.,()?]{8,}$";               //must have 8 characters
            //string password_pattern = "^(?=.*[A-Z])[A-Za-z0-9!@#$%^&*()]{8,}$";                //must have atleast 1 uppercase
             string password_pattern = "^(?=.*[A-Z])(?=.*[0-9])[A-Za-z0-9-+_!@#$%^&*.,?]{8,}$";     //must have atleast 1 nummeric number
            if (Regex.IsMatch(password, password_pattern))
            {
                Console.WriteLine("  Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
            }
        }
    }
}
