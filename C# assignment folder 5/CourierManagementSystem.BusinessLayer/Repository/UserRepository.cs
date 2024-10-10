using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CourierManagementSystem.Entity;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    public class UserRepository : IUserRepository

    {
        // Default constructor
        public UserRepository() { }

        //Parameterized constructor
        User user = new User();
        public UserRepository(int userID, string userName, string email, string password, string contactNumber, string address)
        {
            user.UserID = userID;
            user.UserName = userName;
            user.Email = email;
            user.Password = password;
            user.ContactNumber = contactNumber;
            user.Address = address;

        }
        public override string ToString()
        {
            return $"User {{ userID={user.UserID}, userName='{user.UserName}', email='{user.Email}', " +
                   $"password='{user.Password}', contactNumber=''{user.ContactNumber}',address={user.Address} }}";

        }
        public void DisplayUserInfo()
        {
            Console.WriteLine($"{user.UserID}, {user.UserName},{user.Email},{user.Password},{user.ContactNumber},{user.Address}");
        }
    }
}
