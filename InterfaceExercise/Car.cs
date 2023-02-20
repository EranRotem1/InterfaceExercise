using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : ICompany, IVehicle
    {
        public string Name { get; set; } 
        public string Slogan { get; set; }
        public int NumWheels { get; set; } = 4;
        public string Model { get; set; } 
        public string TypeOfVehicle { get; set; } = "Car";
        public string EffectiveTerrain { get; set; } = "Land : Roads";

        //Car only 
        public string TrunkCapacity { get; set; }
        public bool Electric { get; set; } = false;
    }
}
