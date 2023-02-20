using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle : ICompany
    {
        public int NumWheels { get; set; }
        public string Model { get; set; }
        public string TypeOfVehicle { get; set; }
        public string EffectiveTerrain { get; set; }
    }
}
