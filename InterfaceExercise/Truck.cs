using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck
    {
        public bool HasTruckBed{ get; set; }
        public string TruckBedSize { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }

       public Truck(bool hasTruckBed, string truckBedSize, string color, int numberOfDoors, string model, int year, string name, string logo )
        {
            this.HasTruckBed = hasTruckBed;
            this.TruckBedSize = truckBedSize;
            this.Color = color;
            this.NumberOfDoors = numberOfDoors;
            this.Model = model;
            this.Year = year;
            this.Name = name;
            this.Logo = logo;
        }

    }
}
