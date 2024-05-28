using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AirTrafficControlTower controlTower = new AirportControlTower();

            Airplane airplane1 = new CommercialAirplane(controlTower);
            Airplane airplane2 = new CommercialAirplane(controlTower);

            airplane1.requestTakeoff();
            airplane2.requestLanding();
        }
    }
}
