using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regular_Expression_Practice
{
    internal class ValidateUserName
    {
        public static bool IsValidUserName(string uName)
        {
            //Must be 6 to 12 characters long.
            //Can contain only letters and digits.
            //Must start with a letter.

            string pattern = @"^[A-Z][A-Za-z0-9]{5,11}$";
            return Regex.IsMatch(uName, pattern);
        }

        public static bool IsValidVehicleRegistration(string vehicleNumber)
        {
            //Starts with 2 uppercase letters(e.g., "AB").
            //Followed by 2 to 4 digits(e.g., "1234").
            //Ends with an optional uppercase letter(e.g., "X").
            string pattern = @"^[A-Z][A-Z][0-9]{2,4}[A-Z]?$";
            return Regex.IsMatch(vehicleNumber, pattern);
        }

        public static bool ValidateHexadecimalColorCode(string code)
        {
            //example: #A3C113
            string pattern = @"^#[A-F0-9a-f]{6}$";
            return Regex.IsMatch(code, pattern);
        }

        public static bool ValidateDate(string date)
        {
            //Date format: 12/23/2024
            string pattern = @"^[0-9]{2}/[0-9]{2}/[0-9]{4}$";
            return Regex.IsMatch(date, pattern);
        }

        public static bool ValidateCreditCardNumber(string creditCardNumber)
        {
            //16 digits long, allowing spaces or dashes between every four digits
            string pattern = @"^([0-9]{4}[\s-]{3})[0-9]$";
            return Regex.IsMatch(creditCardNumber, pattern);
        }
    }

}
