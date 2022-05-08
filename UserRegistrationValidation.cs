using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class UserRegistrationValidation
    {
       
        //UC1-validate first name
        public void ValidateFirstName()
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
        public void ValidateLastName()
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
        public void ValidateEmail()
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
        public void ValidateMobileNumber()
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

        //validate password-UC5+UC6+UC7+UC8
        public void ValidatePassword()
        {
            Console.WriteLine("\nPlease Enter your Password:");
            string password = Console.ReadLine();
            //string password_Pattern = "^[a-zA-Z]{8,}$";        //must have atleast 8 characters
            //string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";         //must have atleat 1 uppercase
            //string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";        //must have atleast 1 number
            string password_Pattern = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@?^*!~]).{8,}$";      //must have atleast 1 special character
            if (Regex.IsMatch(password, password_Pattern))
            {
                Console.WriteLine("Password is Valid");
            }
            else
            {
                Console.WriteLine("Password is not Valid");
            }
        }

        //UC9-list of the sample emails
        public List<string> sampleMails = new List<string>()
        {
            "abc@yahoo.com",
            "abc-100@yahoo.com",
            "abc.100@yahoo.com",
            "abc111@abc.com",
            "abc-100@abc.net",
            "abc.100@abc.com.au",
            "abc@1.com",
            "abc@gmail.com.com",
            "abc+100@gmail.com"
        };
        private static string REGEX_EMAIL2 = "^[a-zA-Z0-9]+([.+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3})?$"; // for sample emails
                                                     
        //Method to test sample emails
        public bool ValidateSampleEmails(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL2);
        }
        //Method to get the list
        public List<string> GetList()
        {
            return sampleMails;
        }

        //To print the result
        public void PrintResult(bool result)
        {
            if (result)
            {
                Console.WriteLine("Valid.");
            }
            else
            {
                Console.WriteLine("Invalid.");
            }
        }
        
    }

}
