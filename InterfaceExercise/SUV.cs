using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV
    {

        public bool HasHatchBack { get; set; }
        public string NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int NumberOfDoors { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        

        public SUV(bool hasHatchBack, string numberOfSeats, string color, int numberOfDoors, string model, int year, string name, string logo)
        {
            this.HasHatchBack = hasHatchBack;
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
