//using CourierMangementSystem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CourierManagementSystem.Entity;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    public class EmployeeRepository: IEmployeeRepository
    {
        public EmployeeRepository() { }

        //Parameterized constructor
        Employee employee = new Employee();
        public EmployeeRepository(int employeeID, string employeeName, string email, string contactNumber, string role, double salary)
        {
            employee.EmployeeID = employeeID;
            employee.EmployeeName = employeeName;
            employee.Email = email;
            employee.ContactNumber = contactNumber;
            employee.Role = role;
            employee.Salary = salary;
            
        }
        public override string ToString()
        {
            return $"Employee {{ employeeID={employee.EmployeeID}, employeeName='{employee.EmployeeName}', email='{employee.Email}', " +
                   $"contactNumber='{employee.ContactNumber}', role='{employee.Role}', salary={employee.Salary} }}";

        }

        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"{employee.EmployeeID}, {employee.EmployeeName},{employee.ContactNumber},{employee.Salary},{employee.Role},{employee.Email}");
        }
    }
}
