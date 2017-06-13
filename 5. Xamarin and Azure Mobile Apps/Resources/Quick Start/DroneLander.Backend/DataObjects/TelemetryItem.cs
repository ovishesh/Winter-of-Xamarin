using Microsoft.Azure.Mobile.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneLander.Service.DataObjects
{
    public class TelemetryItem : EntityData
    {
        public string UserId { get; set; }
        public string DisplayName { get; set; }
        public string Tagline { get; set; }
        public double Altitude { get; set; }
        public double DescentRate { get; set; }
        public double Fuel { get; set; }
        public double Thrust { get; set; }
    }
}