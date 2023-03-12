using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Suvs : ICompany, IVehicle

    {
        public Suvs() { }
        public string Name { get; set; } = "International";
        public double YearsInBusiness { get; set; } = 83;

        public string FuelType { get; set; } = "gas";
        public string Color { get; set; } = "red";
        public int NumberOfDoors { get; set; } = 2;
        public string Model { get; set; }=  "Scout";

        public bool Has4WD { get; set; } = true;
        public int SeatingFor { get; set; } = 4;
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
