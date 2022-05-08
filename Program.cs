using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To User Registration Problem");

            //Creating object
            UserRegistrationValidation userRegistrationValidation = new UserRegistrationValidation();

            //UC1
            //userRegistrationValidation.ValidateFirstName();

            ////UC2
            //userRegistrationValidation.ValidateLastName();

            //UC3
            //userRegistrationValidation.ValidateEmail();

            //UC4
            //userRegistrationValidation.ValidateMobileNumber();

            //UC5 + UC6 + UC7 + UC8
            //userRegistrationValidation.ValidatePassword();

            //UC9-Sample Emails
            Console.WriteLine("\nChecking for sample mails :\n ");
            foreach (string mail in userRegistrationValidation.GetList())
            {
                Console.Write(mail + " :  ");
                userRegistrationValidation.PrintResult(userRegistrationValidation.ValidateSampleEmails(mail));
            }
            Console.ReadLine();
        }
    }
}
