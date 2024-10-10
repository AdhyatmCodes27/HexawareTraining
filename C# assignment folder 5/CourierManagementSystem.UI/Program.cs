using CourierManagementSystem.BusinessLayer.CustomExceptions;
using CourierManagementSystem.BusinessLayer.Repository;
using CourierManagementSystem.BusinessLayer.Service;
using CourierManagementSystem.DatabaseLayer;
using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CourierManagementSystem.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeRepository er = new EmployeeRepository(101, "Adhyatm", "abc@email.com", "2323223232", "admin", 12000);
            EmployeeService es = new EmployeeService(er);


            es.DisplayEmployeeInfo();
            es.ToString();

            CourierRepository cr = new CourierRepository();

            ICourierUserService courierUserService = new CourierUserService();
            ICourierAdminService courierAdminService = new CourierAdminService();

            // Admin adds a new courier staff member
            Employee newEmployee = new Employee { EmployeeName = "John Doe", Email = "john.doe@example.com", ContactNumber = "1234567890", Role = "Courier", Salary = 5000 };
            int employeeId = courierAdminService.AddCourierStaff(newEmployee);
            Console.WriteLine($"Added new courier staff with ID: {employeeId}");

            //int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, double weight, string status, string trackingNumber, DateTime deliveryDate, int userId
            // User places a new order
            Courier courier = new Courier
            {
                CourierID = 101,
                
                SenderName = "Alice",
                SenderAddress = "123 Main St",
                ReceiverName="Bob",
                ReceiverAddress="456 Park Ave",
                Weight=10.5,
                Status="Delivered",
                TrackingNumber="abc101",
                DeliveryDate=DateTime.Now.AddDays(2),
                UserId= employeeId
            };
            //courier.CourierID = employeeId;
            string trackingNumber = courierUserService.PlaceOrder(courier);
            Console.WriteLine($"Order placed. Tracking number: {trackingNumber}");

            // Check order status
            string status = courierUserService.GetOrderStatus(trackingNumber);
            Console.WriteLine($"Order status: {status}");

            // Cancel the order
            bool cancelResult = courierUserService.CancelOrder(trackingNumber);
            Console.WriteLine($"Order canceled: {cancelResult}");

            // TASK 7 EXCEPTION HANDLING 
            //TrackingNumberNotFoundException
            CourierUserService courierService = new CourierUserService();

            try
            {
                // Example: Cancel an order by tracking number
                bool orderCancelled = courierService.CancelOrder("TN1234");
                if (orderCancelled)
                {
                    Console.WriteLine("Order successfully cancelled.");
                }
                else
                {
                    Console.WriteLine("Order cannot be cancelled as it is already delivered.");
                }
            }
            catch (TrackingNumberNotFoundException ex)
            {
                // Handle custom exception for tracking number not found
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                // Handle any other general exception
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("End of transaction.");
            }

            // TASK 8 
            CourierCompanyCollection companyCollection = new CourierCompanyCollection();

            // Adding companies
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 1" });
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 2" });
            companyCollection.AddCourierCompany(new CourierCompany { CompanyName = "Company 3" });

            // list of all courier companies
            List<CourierCompany> companies = companyCollection.GetAllCourierCompanies();

            // Display the list of companies
            Console.WriteLine("List of Courier Companies:");
            foreach (var company in companies)
            {
                Console.WriteLine(company.CompanyName);
            }

            // TASK 10 DATABASE CONNECTION

            CourierServiceDB courierServiceDb = new CourierServiceDB();

            //courierServiceDb.GetEmployeeDetails();

           // Console.WriteLine("Press any key to exit.");







            //2.Insert a new employee
            Employee newE = new Employee
            {
                EmployeeID = 19,
                EmployeeName = "Happy Singh",
                Email = "Aditya@example.com",
                ContactNumber = "1234567890",
                Role = "Manager",
                Salary = 75000.00D
            };
            courierServiceDb.InsertEmployee(newE);

            // 3. Update an employee's details
            //Employee updateEmployee = new Employee
            //{
            //    employeeID = 1, // Assuming EmployeeID 1 exists
            //    email = "new.email@example.com",
            //    contactNumber = "0987654321",
            //    role = "Senior Manager",
            //    salary = 80000.00D
            //};
            //courierServiceDb.UpdateEmployee(updateEmployee);

            // 4. Delete an employee
            //courierServiceDb.DeleteEmployee(2);  // EmployeeID  is  2 

            // 5. Get the employee with the highest salary
            //courierServiceDb.GetEmployeeWithMaxSalary();



            Console.ReadKey();
        }
    }
}
