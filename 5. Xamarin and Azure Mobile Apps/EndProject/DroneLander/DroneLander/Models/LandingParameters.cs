using DroneLander.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DroneLander
{
    public enum LandingResultType { Landed, Kaboom, }
    public class LandingParameters
    {
        public LandingParameters()
        {
            this.Altitude = CoreConstants.StartingAltitude;
            this.Velocity = CoreConstants.StartingVelocity;
            this.Fuel = CoreConstants.StartingFuel;
            this.Thrust = CoreConstants.StartingThrust;
        }

        public double Altitude;
        public double Velocity;
        public double Fuel;
        public double Thrust;
    }
}