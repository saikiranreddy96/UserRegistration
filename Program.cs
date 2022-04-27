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
            //Calling Methods

            ////UC1
            //UserRegistrationValidation.ValidateFirstName();

            ////UC2
            //UserRegistrationValidation.ValidateLastName();

            ////UC3
            //UserRegistrationValidation.ValidateEmail();

            ////UC4
            //UserRegistrationValidation.ValidateMobileNumber();

            //UC5+UC6+UC7
            UserRegistrationValidation.ValidatePassword();

            Console.ReadLine();
        }
    }
}
