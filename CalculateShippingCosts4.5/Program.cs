﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Task 4 question 13

namespace CalculateShippingCosts4._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string sourceAddress = "123 Main Street, Los Angeles, California";
            string destinationAddress = "456 Oak Avenue, San Francisco, California";
  
            double parcelWeight = 10.5;

            double shippingCost = CalculateShippingCost(sourceAddress, destinationAddress, parcelWeight);
    
            Console.WriteLine($"Shipping cost from {sourceAddress} to {destinationAddress} for a parcel of {parcelWeight} kg is: ${shippingCost:F2}");

            Console.ReadKey();  
        }

        // Function to calculate the shipping cost
        static double CalculateShippingCost(string source, string destination, double weight)
        {
            // Mocked distance calculation based on source and destination addresses (for simplicity)
            double distance = CalculateDistanceBetweenAddresses(source, destination);

            // Shipping cost formula
            double baseCost = 5.00;        // Base shipping cost
            double costPerKm = 0.50;       // Cost per km
            double costPerKg = 2.00;       // Cost per kg

            // Total cost calculation
            double totalCost = baseCost + (costPerKm * distance) + (costPerKg * weight);

            return totalCost;
        }

        // Mock function to calculate distance between two addresses
        static double CalculateDistanceBetweenAddresses(string source, string destination)
        {
            if (source == destination)
            {
                return 0;
            }
            
            return 600; 
        }
    }
}
