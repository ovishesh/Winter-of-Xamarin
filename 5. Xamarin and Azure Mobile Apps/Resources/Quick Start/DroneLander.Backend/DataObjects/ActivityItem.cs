using Microsoft.Azure.Mobile.Server;
using System;

namespace DroneLander.Service.DataObjects
{
    public class ActivityItem : EntityData
    { 
        public string Status { get; set; }

        public string Description { get; set; }

        public DateTime ActivityDate { get; set; }
    }
}