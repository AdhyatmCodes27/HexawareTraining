using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace CourierManagementSystem.BusinessLayer.Repository
{
    internal class LocationRepository : ILocationRepository
    {
        // Default constructor
        public LocationRepository() { }

        // Parameterized constructor
        Location location = new Location();
        public LocationRepository(int locationID, string locationName, string address)
        {
            location.LocationID = locationID;
            location.LocationName = locationName;
            location.Address = address;
        }

        public override string ToString()
        {
            return $"Location {{ locationID={location.LocationID}, locationName='{location.LocationName}', address='{location.Address}' }}";
        }
    }
}
