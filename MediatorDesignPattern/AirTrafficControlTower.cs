using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public interface AirTrafficControlTower
    {
        void requestTakeoff(Airplane airplane);
        void requestLanding(Airplane airplane);
    }
}
