using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

//Task 4 question 10

namespace CustomerDataValidation4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test cases
            Console.WriteLine("Adhyatm Mishra");
            Console.WriteLine( ValidateCustomerInfo("Adhyatm Mishra", "name"));

            Console.WriteLine("adhyatm mishra");
            Console.WriteLine( ValidateCustomerInfo("adhyatm mishra", "name"));

            Console.WriteLine("002 Saideep Apt");
            Console.WriteLine(ValidateCustomerInfo("002 Saideep Apt", "address"));

            Console.WriteLine("002 Saideep @Apt");
            Console.WriteLine(ValidateCustomerInfo("002 Saideep @Apt", "address"));

            Console.WriteLine("123-456-7890");
            Console.WriteLine(ValidateCustomerInfo("123-456-7890", "phone"));

            Console.WriteLine("1234567890");
            Console.WriteLine(ValidateCustomerInfo("1234567890", "phone"));        

            Console.ReadKey();  
        }

        static bool ValidateCustomerInfo(string data, string detail)
        {
            switch (detail.ToLower())
            {
                case "name":
                    return ValidateName(data);

                case "address":
                    return ValidateAddress(data);

                case "phone":
                    return ValidatePhoneNumber(data);

                default:
                    return false;
            }
        }

      
        static bool ValidateName(string name)
        {
            // Check if name contains only letters and spaces
            if (!Regex.IsMatch(name, @"^[A-Za-z\s]+$"))
            {
                return false;
            }

            string[] words = name.Split(' ');
            foreach (string word in words)
            {
                if (word.Length == 0 || char.IsLower(word[0]) || word.Substring(1) != word.Substring(1).ToLower())
                {
                    return false;
                }
            }

            return true;
        }

        // Validate address No special characters except numbers and letters
        static bool ValidateAddress(string address)
        {
            // Check if the address contains only letters, numbers, and spaces (no special characters)
            return Regex.IsMatch(address, @"^[A-Za-z0-9\s]+$");
        }

        // Validate phone number: Must follow ###-###-####
        static bool ValidatePhoneNumber(string phoneNumber)
        {
            // Check if the phone number matches the pattern ###-###-####
            return Regex.IsMatch(phoneNumber, @"^\d{3}-\d{3}-\d{4}$");
        }
    }
}
