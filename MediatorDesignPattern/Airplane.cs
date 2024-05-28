using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDesignPattern
{
    public interface Airplane
    {
        void requestTakeoff();
        void requestLanding();
        void notifyAirTrafficControl(string message);
    }
}
