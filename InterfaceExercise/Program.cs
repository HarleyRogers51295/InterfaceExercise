using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //hasTrunk,numberOfSeats,color,numberOfDoors,model,year,name,logo
            Car honda = new Car(true, "5", "blue", 4, "Civic", 2018, "Blue Bullet", "Honda");
            //hasTruckBed,truckBedSize,color,numberOfDoors,model,year,name,logo
            Truck gmc = new Truck(true, "Large", "Tan", 2, "Sierra", 2016, "Junker", "GMC");
            //hasHatchBack,numberOfSeats,color,numberOfDoors,model,year,name,logo
            SUV jeep = new SUV(false, "5", "silver", 5, "Grand Cherokee", 2010, "Hi ho Silver!", "JEEP");


            Console.WriteLine($"Hello! We have three cars! We have a {honda.GetType().Name}, {gmc.GetType().Name}, " +
                $"and {jeep.GetType().Name}. \nThe {honda.GetType().Name} is a {honda.Year}, {honda.Logo} {honda.Model}" +
                $"\nWe call it the {honda.Name}. Does it have a trunk? That is {honda.HasTrunk}. \nIt has {honda.NumberOfSeats} seats, " +
                $"{honda.NumberOfDoors} doors, and it is {honda.Color}.\n \nThe {gmc.GetType().Name} is a {gmc.Year}, {gmc.Logo} {gmc.Model}" +
                $"\nWe call it the {gmc.Name}. Does it have a truck bed? That is {gmc.HasTruckBed}. \nIt's bed is {gmc.TruckBedSize}, " +
                $"{gmc.NumberOfDoors} doors, and it is {gmc.Color}.\n \nThe {jeep.GetType().Name} is a {jeep.Year}, {jeep.Logo} {jeep.Model}" +
                $"\nWe call it the {jeep.Name}. Does it have a hatch back? That is {jeep.HasHatchBack}. \nIt has {jeep.NumberOfSeats} seats, " +
                $"{jeep.NumberOfDoors} doors, and it is {jeep.Color}.");

            Console.WriteLine();
            Console.WriteLine("For organizational pourposes we will list these out.");
            Console.WriteLine();
            Console.WriteLine($"For {honda.GetType().Name}, {honda.Logo}, {honda.Model} " +
                $"\nColor: {honda.Color} \nNumber of Doors: {honda.NumberOfDoors}\nYear: {honda.Year}\nNumber of Seats: {honda.NumberOfSeats}\nTrunk: {honda.HasTrunk}.");
            Console.WriteLine();
            Console.WriteLine($"For {gmc.GetType().Name}, {gmc.Logo}, {gmc.Model} " +
                $"\nColor: {gmc.Color} \nNumber of Doors: {gmc.NumberOfDoors}\nYear: {gmc.Year}\nTruck Bed: {gmc.HasTruckBed}\nTrunk Bed Size: {gmc.TruckBedSize}.");
            Console.WriteLine();
            Console.WriteLine($"For {jeep.GetType().Name}, {jeep.Logo}, {jeep.Model} " +
                $"\nColor: {jeep.Color} \nNumber of Doors: {jeep.NumberOfDoors}\nYear: {jeep.Year}\nNumber of Seats: {jeep.NumberOfSeats}\nHatch Back: {jeep.HasHatchBack}.");

        }
    }
}
