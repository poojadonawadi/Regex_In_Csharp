using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Regular_Expression_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age");
            string age = Console.ReadLine();
            Console.WriteLine("Enter phone number");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the zipcode");
            string zipcode = Console.ReadLine();

            bool isNameValid = ValidateName(name);
            bool isAgeValid = ValidateAge(age);
            bool isPhoneValid = ValidatePhone(phone);
            bool isZipcodeValid = ValidateZipCode(zipcode);
            
            Console.WriteLine("------Details-----");

            if (!isNameValid)
            {
                Console.WriteLine("Name should start with with capital letter");
                return;
            }
            else
            {
                Console.WriteLine($"Name is: {name}");
            }

            if (!isAgeValid)
            {
                Console.WriteLine("Age should be between 18 and 70");
                return;
            }
            else
            {
                Console.WriteLine($"Age is: {age}");
            }
            if (!isPhoneValid)
            {
                Console.WriteLine("Phone number should be 10 digits");
                return;
            }
            else
            {
                Console.WriteLine($"Phone number is: {phone}");
            }
            if (!isZipcodeValid)
            {
                Console.WriteLine("Zipcode should be 5to 6 digits");
                return;
            }
            else 
            { 
            Console.WriteLine($"Zipcode is: {zipcode}");
            }
        }
        public static bool ValidateName(string name)
        {
            //first lettermust me capital and remaining small
            string pattern = @"^[A-Z][a-z]{2,50}";
            return Regex.IsMatch(name, pattern);
        }
        public static bool ValidateAge(string age)
        {
            //[0-9]{50}
            string pattern = @"^\d+$";
            if (Regex.IsMatch(age, pattern))        
            {
                int ageValidation = int.Parse(age);
                return ageValidation >= 18 && ageValidation <= 70;
            }
            return false;
        }
        public static bool ValidatePhone(string phone)
        {
            //[0-9]{10}
            string pattern = @"^\d{10}$";
            return Regex.IsMatch(phone, pattern);
        }
        public static bool ValidateZipCode(string zipcode)
        {
            //[0-9]{5, 6}
            string pattern = @"^\d{5,6}";
            return Regex.IsMatch(zipcode, pattern);
        }
    }
}
