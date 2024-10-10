using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Entity
{
    public class Location
    {
        private int locationID;
        private string locationName;
        private string address;

        // Default constructor
        public Location() { }

        

        // Getters and setters
        public int LocationID { get => locationID; set => locationID = value; }
        public string LocationName { get => locationName; set => locationName = value; }
        public string Address { get => address; set => address = value; }

        
    }
}
