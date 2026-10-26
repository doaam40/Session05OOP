using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_AssignmentOOP
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            return $"{shipment.TrackingCode} | {shipment.GetType().Name} | {shipment.Weight} KG | {shipment.GetTrackingStatus()}";
        }
        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment.GetTrackingStatus() == "Delivered")
                return true;
            return false;
        }
    }
}
