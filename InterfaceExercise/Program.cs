using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            Car car = new Car() {
                Name = "Tesla",
                Slogan = "To accelerate the advent of sustainable transport and electric technology.",
                NumWheels = 4,
                Model = "X",
                TypeOfVehicle = "Car",
                EffectiveTerrain = "Roads",
                
                TrunkCapacity = "Medium",
                Electric = true
            };
            
            SUV suv = new SUV() {
                Name = "Subaru",
                Slogan = "Love Means Being More Than a Car Company.",
                NumWheels = 4,
                Model = "Outback",
                TypeOfVehicle = "SUV",
                EffectiveTerrain = "Roads+",
                
                FourWheelDrive = true,
            };

            Truck truck = new Truck() {
                Name = "RAM",
                Slogan = "Guts. Glory. RAM.",
                NumWheels = 4,
                Model = "OffRoader",
                TypeOfVehicle = "Truck",
                EffectiveTerrain = "Roads+",

                TruckBed = true,
                DriverSideStep = true
            };

            List<IVehicle> vehicles = new List<IVehicle>() { car, suv, truck};

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Here at {vehicle.Name} we believe that {vehicle.Slogan} \nAnd we mean that." +
                    $"\nWe are excited to share with you our brand new, top of the line {vehicle.TypeOfVehicle}, the {vehicle.Name} {vehicle.Model}\n" +
                    $"Sporting {vehicle.NumWheels} whole wheels that can drive on {vehicle.EffectiveTerrain}.\n\n");

            }
        }
    }
}
