using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_ASSIGNMENT
{
    internal class StandardShipment : Shipment 
    {
        public StandardShipment() { }
        public StandardShipment(string trackingCode)
            : base(trackingCode)
        {
        }

        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
        }

        public override void PrintShipment()
        {
            Console.WriteLine($@"Tracking Code: {TrackingCode}
            Description: {Description}
            Destination :
            City : {Destination.City}
            Street : {Destination.Street}
            Building Number : {Destination.BuildingNumber}
            Weight: {Weight} kg
            Delivery Fee: {DeliveryFee}
            Estimated Cost : {EstimatedCost}
            Destination: {Destination}");
        }
    }
}
