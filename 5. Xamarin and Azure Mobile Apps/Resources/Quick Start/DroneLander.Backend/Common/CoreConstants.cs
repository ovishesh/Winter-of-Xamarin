using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DroneLander.Service.Common
{
    public static class CoreConstants
    {
        public const string MissionControlTransmissionConnection = "Endpoint=sb://dronelandermissioncontrol.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=w4LhH30a49mkOqD5qdgQ5qo9/odH27XCF15Kiy5f6Ek=";

        //Replace [ENTER_MISSION_EVENT_NAME] with the event name 
        //value provided by the event facilitator
        public const string MissionEventName = "[ENTER_MISSION_EVENT_NAME]";
    }
}