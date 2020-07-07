using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {

        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }


    }
}
