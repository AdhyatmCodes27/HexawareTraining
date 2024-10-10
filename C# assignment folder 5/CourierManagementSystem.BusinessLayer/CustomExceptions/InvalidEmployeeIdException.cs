using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.CustomExceptions
{
    public class InvalidEmployeeIdException: RankException
    {
        public InvalidEmployeeIdException() : base("Invalid employee ID entered.")
        {
        }

        public InvalidEmployeeIdException(string message) : base(message)
        {
        }

        public InvalidEmployeeIdException(string message, RankException inner) : base(message, inner)
        {
        }
    }
}
