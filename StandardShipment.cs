using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_AssignmentOOP
{
    internal class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string _trackingCode, string _description, double _weight, decimal _deliveryFee, DeliveryAddress _destination) : base(_trackingCode, _description, _weight, _deliveryFee, _destination)
        {

        }
        public override decimal EstimatedCost => DeliveryFee + (decimal)(Weight * 5);

        public decimal CalculateInsurance()
        {
            return 5m / 100m * EstimatedCost;
        }

        public string GetTrackingStatus() => "Ready";


        public override void PrintShipment()
        {
            Console.WriteLine($"Standard Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Estimated Cost: {EstimatedCost} EGP");
        }
        public override string ToString()
        {
            return $"Standard Shipment: Tracking Code: {TrackingCode}, Description: {Description}, Weight: {Weight} KG, Delivery Fee: {DeliveryFee} EGP, Estimated Cost: {EstimatedCost} EGP";
        }
        public StandardShipment CopyShipment()
        {
            return this;
        }
        public StandardShipment ShallowCopy()
        {
            return (StandardShipment)MemberwiseClone();
        }
        public StandardShipment DeepCopy()
        {
            StandardShipment copy = (StandardShipment)MemberwiseClone();
            copy.Destination = new DeliveryAddress(Destination.City, Destination.Street, Destination.BuildingNumber);
            return copy;
        }
    }
}
