using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander.Helpers
{
    public static class ActivityHelper
    {
        public static async void AddActivityAsync(LandingResultType landingResult)
        {
            try
            {
                await TelemetryManager.DefaultManager.AddActivityAsync(new ActivityItem()
                {
                    ActivityDate = DateTime.Now.ToUniversalTime(),
                    Status = landingResult.ToString(),
                    Description = (landingResult == LandingResultType.Landed) ? "The Eagle has landed!" : "That's going to leave a mark!"
                });
            }
            catch { }
        }
    }
}