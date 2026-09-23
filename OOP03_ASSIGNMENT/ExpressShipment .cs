using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_ASSIGNMENT
{
    public class ExpressShipment : Shipment
    {
        private decimal extera_fee;
        public decimal ExtraFee
        {
            get { return extera_fee; }
            set
            {
                if (extera_fee >= 0)
                {
                    extera_fee = value;
                }
            }
        }
        public override decimal EstimatedCost { get { return DeliveryFee + (Weight * 5) + ExtraFee; } }

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
            ExtraFee : {ExtraFee}
            Estimated Cost : {EstimatedCost}
            Destination: {Destination}");

        }

        public ExpressShipment() { }
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, decimal fee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.ExtraFee = fee;
        }

    }
}
