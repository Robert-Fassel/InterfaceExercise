using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Trucks : ICompany, IVehicle
    {   
        public Trucks() { }



        public string Name { get; set; } = "Chevrolet";
        public double YearsInBusiness { get; set; } = 112;

        public string FuelType { get; set; } = "diesel";
        public string Color { get; set; } = "black";
        public int NumberOfDoors { get; set; } = 2;
        public string Model { get; set; } = "Silverado";
        public bool IsDually { get; set; } = true;
        public int BedLength { get; set; } = 8;
        public void PrintStats()
        {
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Fuel used: {FuelType}");
            Console.WriteLine($"Vehicle color: {Color}");
            Console.WriteLine($"Number of doors: {NumberOfDoors}");
            Console.WriteLine("....................");

        }
    }
}
