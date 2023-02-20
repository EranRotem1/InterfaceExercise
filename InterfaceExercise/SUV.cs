using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class SUV : ICompany, IVehicle
    {
        public string Name { get; set; }
        public string Slogan { get; set; }
        public int NumWheels { get; set; } = 4;
        public string Model { get; set; }
        public string TypeOfVehicle { get; set; } = "SUV";
        public string EffectiveTerrain { get; set; } = "Land : Roads";

        //SUV only
        public bool FourWheelDrive { get; set; } 
        public void Honk()
        {
            Console.WriteLine("Honk");
        }
    }
}
