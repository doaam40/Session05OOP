using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_AssignmentOOP
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            shipment.GetTrackingStatus();
        }
        public void PrintInsurance(IInsurable shipment)
        {
            shipment.CalculateInsurance();
        }
    }
}
