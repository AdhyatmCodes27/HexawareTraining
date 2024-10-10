﻿using System;

namespace CourierManagementSystem.BusinessLayer.CustomExceptions
{
    public class TrackingNumberNotFoundException : RankException
    {
        // Default constructor
        public TrackingNumberNotFoundException() : base("Tracking number not found.")
        {
        }

        // Constructor that takes a custom message
        public TrackingNumberNotFoundException(string message) : base(message)
        {
        }

        // Constructor that takes a custom message and an inner exception
        public TrackingNumberNotFoundException(string message, RankException inner) : base(message, inner)
        {
        }
    }
}
