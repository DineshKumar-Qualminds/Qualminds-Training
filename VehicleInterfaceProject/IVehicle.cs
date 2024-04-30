using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleInterfaceProject
{
    public interface IVehicle
    {
        void Make(string company);
        void NumberOfWheels(int number);
        void VehicleType(string transportMode);
    }

}
