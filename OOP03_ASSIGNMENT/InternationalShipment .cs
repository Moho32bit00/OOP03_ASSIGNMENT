using System;
using System.Collections.Generic;
using System.Text;

namespace OOP03_ASSIGNMENT
{
    public class InternationalShipment : Shipment
    {
        public string DestinationCountry
        {
            get;
            set;
        }
        public decimal CustomsFee
        {
            get;
            set;

        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }
        public override void PrintShipment()
        {
            Console.WriteLine($@"Tracking Code: {TrackingCode}
        Description: {Description}
        Destination :
        Destination Country : {DestinationCountry}
        City : {Destination.City}
        Street : {Destination.Street}
        Building Number : {Destination.BuildingNumber}
        Weight: {Weight} kg
        Delivery Fee: {DeliveryFee}
        CustomsFee : {CustomsFee}
        Estimated Cost : {EstimatedCost}
        Destination: {Destination}");
        }

        public virtual void GenerateCustomsReport () {}
        public InternationalShipment() { }
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination, string DestinationCountry, decimal CustomsFee) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            this.CustomsFee = CustomsFee;
            this.DestinationCountry = DestinationCountry;
        }
    }
}
