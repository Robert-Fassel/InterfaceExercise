using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
 
    public class Cars : ICompany, IVehicle
    {
        public Cars() { }
        public string Name { get; set; } = "Tesla";
        public double YearsInBusiness { get; set; } = 20;

        public string FuelType { get; set; } = "electric";
        public string Color { get; set; } = "orange";
        public int NumberOfDoors { get; set; } = 2;
        public string Model { get; set; } = "Roadster";
        public bool IsHatchBack { get; set; } = false;
        public bool IsSporty { get; set; } = true;

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
