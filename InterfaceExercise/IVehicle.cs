using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        public string FuelType { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public void PrintStats();
    }
}
