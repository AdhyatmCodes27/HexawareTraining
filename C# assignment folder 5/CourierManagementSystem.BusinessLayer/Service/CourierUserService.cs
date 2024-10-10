using CourierManagementSystem.BusinessLayer.CustomExceptions;
using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.Service
{
    public class CourierUserService : ICourierUserService
    {
        private List<Courier> courierOrders = new List<Courier>(); // Simulated order storage

        // Place a new courier order and return a unique tracking number
        public string PlaceOrder(Courier courierObj)
        {
            courierOrders.Add(courierObj);
            return courierObj.TrackingNumber;
        }

        // Get the status of a courier order based on tracking number
        public string GetOrderStatus(string trackingNumber)
        {
            Courier order = courierOrders.Find(c => c.TrackingNumber == trackingNumber);
            if (order != null)
            {
                return order.Status;
            }
            return "Order not found";
        }

        // Cancel a courier order
        public bool CancelOrder(string trackingNumber)
        {
            Courier order = courierOrders.Find(c => c.TrackingNumber == trackingNumber);
            //if (order != null && order.Status != "Delivered")
            //{
            //    courierOrders.Remove(order);
            //    return true;
            //}
            //return false;

            if (order == null)
            {
                // Throw custom exception if tracking number is not found
                throw new TrackingNumberNotFoundException($"Tracking number {trackingNumber} was not found.");
            }

            if (order.Status == "Delivered")
            {
                return false;
            }

            courierOrders.Remove(order);
            return true;

        }

        // Get a list of orders assigned to a specific courier staff member
        public List<Courier> GetAssignedOrders(int courierStaffId)
        {
            // Assuming `userId` represents the courier staff ID
            return courierOrders.FindAll(c => c.UserId == courierStaffId);
        }
    }
}
