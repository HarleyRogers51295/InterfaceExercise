using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle , ICompany
    {
       public bool HasTrunk { get; set; }
        public string NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public Car(bool hasTrunk, string numberOfSeats, string color, int numberOfDoors, string model, int year, string name, string logo)
        {
            this.HasTrunk = hasTrunk;
            this.NumberOfSeats = numberOfSeats;
            this.Color = color;
            this.NumberOfDoors = numberOfDoors;
            this.Model = model;
            this.Year = year;
            this.Name = name;
            this.Logo = logo;
        }
        

    }
}
