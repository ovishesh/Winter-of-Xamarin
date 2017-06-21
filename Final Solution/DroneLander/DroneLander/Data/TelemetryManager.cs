using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;

namespace DroneLander
{
    public partial class TelemetryManager
    {
        static TelemetryManager defaultInstance = new TelemetryManager();
        MobileServiceClient client;

        IMobileServiceTable<ActivityItem> activitiesTable;

        private TelemetryManager()
        {
            this.client = new MobileServiceClient(Common.MobileServiceConstants.AppUrl);
            this.activitiesTable = client.GetTable<ActivityItem>();
        }

        public async Task AddActivityAsync(ActivityItem item)
        {
            try
            {
                await activitiesTable.InsertAsync(item);
            }
            catch { }
        }

        public async Task<List<ActivityItem>> GetAllActivityAync()
        {
            List<ActivityItem> activity = new List<ActivityItem>();

            try
            {
                IEnumerable<ActivityItem> items = await activitiesTable.ToEnumerableAsync();
                activity = new List<ActivityItem>(items.OrderByDescending(o => o.ActivityDate));
            }
            catch { }

            return activity;
        }

        public static TelemetryManager DefaultManager
        {
            get
            {
                return defaultInstance;
            }
            private set
            {
                defaultInstance = value;
            }
        }

        public MobileServiceClient CurrentClient
        {
            get { return client; }
        }
    }
}