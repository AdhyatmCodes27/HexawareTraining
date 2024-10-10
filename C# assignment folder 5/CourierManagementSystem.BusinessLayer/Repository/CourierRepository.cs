using CourierManagementSystem.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagementSystem.BusinessLayer.Repository
{
    public class CourierRepository: ICourierRepository
    {
        public CourierRepository() { }

        //Parameterized constructor
        Courier courier = new Courier();

        public CourierRepository(int courierID, string senderName, string senderAddress, string receiverName, string receiverAddress, double weight, string status, string trackingNumber, DateTime deliveryDate, int userId)
        {
             
            courier.CourierID = courierID;
            courier.SenderName = senderName;
            courier.SenderAddress = senderAddress;
            courier.ReceiverName = receiverName;
            courier.ReceiverAddress = receiverAddress;
            
            courier.Weight = weight;
            courier.Status = status;
            //courier.TrackingNumber = trackingNumber;
            courier.DeliveryDate = deliveryDate;
            courier.UserId = userId;

        }
        public override string ToString()
        {
            return $"Courier {{ courierID={courier.CourierID}, SenderName='{courier.SenderName}', senderAddress='{courier.SenderAddress}', receiverName='{courier.ReceiverName}' " +
                   $"receiverAddress='{courier.ReceiverAddress}', weight='{courier.Weight}', status={courier.Status}' , deliveryDate='{courier.DeliveryDate}', userId='{courier.UserId}'}} ";

        }

        public void DisplayCourierInfo()
        {
            Console.WriteLine($"{courier.CourierID}, {courier.SenderName},{courier.SenderAddress},{courier.ReceiverAddress},{courier.Weight},{courier.Status} , {courier.DeliveryDate}, {courier.UserId} ");
        }
    }
}

//private int courierID;
//private string senderName;
//private string senderAddress;
//private string receiverName;
//private string receiverAddress;
//private double weight; string status,  string trackingNumber, DateTime deliveryDate, int userId
