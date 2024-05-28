using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public class CommercialAirplane : Airplane
    {
        private AirTrafficControlTower _mediator;

        public CommercialAirplane(AirTrafficControlTower mediator)
        {
            _mediator = mediator;
        }
        public void notifyAirTrafficControl(string message)
        {
            Console.WriteLine("Commercial Airplane : " + message);
        }
        public void requestLanding()
        {
            _mediator.requestLanding(this);
        }

        public void requestTakeoff()
        {
            _mediator.requestTakeoff(this);
        }
    }
}
