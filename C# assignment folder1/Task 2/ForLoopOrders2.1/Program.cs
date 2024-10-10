using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Task 2: Loops and Iteration  
//5. Write a C# program that uses a for loop to display all the orders for a specific customer. 

namespace ForLoopOrders2._1
{
    internal class Program
    {
        class Order
        {
            public string CustomerName { get; set; }
            public string OrderID { get; set; }

            public Order(string customerName, string orderId)
            {
                CustomerName = customerName;
                OrderID = orderId;
            }
        }
        static void Main()
        {
            //  list of orders
            List<Order> orders = new List<Order>
        {
            new Order("Adhyatm Mishra", "ORD001"),
            new Order("Purva Patil", "ORD002"),
            new Order("Adhyatm Mishra", "ORD003"),
            new Order("Shrutika Pawar", "ORD004"),
            new Order("Mansi Patil", "ORD005")
        };

      
            string customerName = "Adhyatm Mishra";  
            
            Console.WriteLine($"Orders for customer: {customerName}");
            bool orderFound = false;

            for (int i = 0; i < orders.Count; i++)
            {
                if (orders[i].CustomerName == customerName)
                {
                    Console.WriteLine($"Order ID: {orders[i].OrderID}");
                    orderFound = true;
                }
            }

            if (!orderFound)
            {
                Console.WriteLine("No orders found for this customer.");
            }
            Console.ReadKey();  
        }
    }
}
