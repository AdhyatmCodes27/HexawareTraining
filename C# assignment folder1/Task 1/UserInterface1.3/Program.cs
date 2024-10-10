using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.Implement User Authentication 1. Create a login system for employees and customers using C#  
//control flow statements.  
namespace UserInterface1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample user credentials
            string username, password;

            // Input for username and password
            Console.Write("Enter username: ");
            username = Console.ReadLine();

            Console.Write("Enter password: ");
            password = Console.ReadLine();

            
            if (username.StartsWith("EMP"))
            {
                
                if (AuthenticateEmployee(username, password))
                {
                    Console.WriteLine("Employee login successful!");
                    
                }
                else
                {
                    Console.WriteLine("Invalid employee credentials.");
                }
            }
            else if (username.StartsWith("CUST"))
            {
                
                if (AuthenticateCustomer(username, password))
                {
                    Console.WriteLine("Customer login successful!");
                    
                }
                else
                {
                    Console.WriteLine("Invalid customer credentials.");
                }

            }

            else
            {
                Console.WriteLine("Unknown user type. Please enter a valid username.");
            }

            Console.ReadKey();  
        }
        
        static bool AuthenticateEmployee(string username, string password)
        {
            
            if (username == "EMP123" && password == "empPass")
            {
                return true;
            }
            return false;
        }
        
        static bool AuthenticateCustomer(string username, string password)
        {
            if (username == "CUST456" && password == "custPass")
            {
                return true;
            }
            return false;
        }
        
    }
}
