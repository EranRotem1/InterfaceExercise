using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : ICompany, IVehicle
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public int NumWheels { get; set; } = 4;
        public string Model { get; set; } 
        public string TypeOfVehicle { get; set; } = "Truck";
        public string EffectiveTerrain { get; set; } = "Land : Roads";

        //Truck only
        public bool TruckBed { get; set; } = true;
        public bool DriverSideStep { get; set; } = true;
    }
}
