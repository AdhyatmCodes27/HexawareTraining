using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.Entity
{
    public class Courier
    {
        private static int trackingNumberCounter = 1000;
        private int courierID;
        private string senderName;
        private string senderAddress;
        private string receiverName;
        private string receiverAddress;
        private double weight;
        private string status;
        private string trackingNumber;
        private DateTime deliveryDate;
        private int userId;

        // Default constructor
        //public Courier() 
        //{
        //    // Increment static counter and assign it as tracking number
        //    trackingNumber = GenerateTrackingNumber();
        //}

        // Generate a unique tracking number using a static counter
        //public string GenerateTrackingNumber()
        //{
        //    return $"T-{++trackingNumberCounter}";
        //}



        // Getters and setters
        public string TrackingNumber { get => trackingNumber; set => trackingNumber=value; }
        public string Status { get => status; set => status = value; }

        public int CourierID { get => courierID; set => courierID = value; }
        public string SenderName { get => senderName; set => senderName = value; }
        public string SenderAddress { get => senderAddress; set => senderAddress = value; }
        public string ReceiverName { get => receiverName; set => receiverName = value; }
        public string ReceiverAddress { get => receiverAddress; set => receiverAddress = value; }
        public double Weight { get => weight; set => weight = value; }
       
        public DateTime DeliveryDate { get => deliveryDate; set => deliveryDate = value; }
        public int UserId { get => userId; set => userId = value; }

       
    }
}
