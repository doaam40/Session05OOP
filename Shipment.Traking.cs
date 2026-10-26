using System;
using System.Collections.Generic;
using System.Text;

namespace Session05_AssignmentOOP
{
    internal abstract partial class Shipment : ITrackable
    {
        public virtual string TrackingStatus { get; set; }
        public virtual string GetTrackingStatus()
        {
            throw new NotImplementedException();
        }
        public virtual string UpdateTrackingStatus()
        {
            throw new NotImplementedException();
        }
    }
}
