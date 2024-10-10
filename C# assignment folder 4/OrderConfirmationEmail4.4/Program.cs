using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Tak 4 question 12

namespace OrderConfirmationEmail4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Customer details and order information
            string customerName = "Adhyatm Mishra";
            string orderNumber = "ORD123456";
            string deliveryAddress = "Udyam Nagar Near Bus Stand, Karjat, Raigad, Maharashtra 410201";
            DateTime expectedDeliveryDate = DateTime.Now.AddDays(5);  // Delivery expected in 5 days

            //email content
            string emailContent = GenerateOrderConfirmationEmail(customerName, orderNumber, deliveryAddress, expectedDeliveryDate);

            Console.WriteLine("Order Confirmation Email:");
            Console.WriteLine(emailContent);

            Console.ReadKey();
        }

        // Function to generate an order confirmation email
        static string GenerateOrderConfirmationEmail(string customerName, string orderNumber, string deliveryAddress, DateTime expectedDeliveryDate)
        {
            //email body
            string emailBody = $@"
        Dear {customerName},

        Thank you for your order!

        Your order number is {orderNumber}.

        We are pleased to confirm that your order has been successfully processed. Your order will be delivered to the following address:

        {deliveryAddress}

        The expected delivery date for your order is: {expectedDeliveryDate.ToString("dddd, MMMM dd, yyyy")}

        If you have any questions regarding your order, feel free to contact our customer service team.

        Thank you for shopping with us!

        Best regards,
        The Sales Team
        ";

            return emailBody;
        }
    }
}
