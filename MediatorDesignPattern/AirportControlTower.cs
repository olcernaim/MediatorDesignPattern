using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class AirportControlTower : AirTrafficControlTower
    {
        public void requestLanding(Airplane airplane)
        {
            airplane.notifyAirTrafficControl("Request landing clearence");
        }

        public void requestTakeoff(Airplane airplane)
        {
            airplane.notifyAirTrafficControl("Request take off clearence");
        }
    }
}
