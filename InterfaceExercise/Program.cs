﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: public int NumberOfWheels { get; set; }
                 */
            

            //In ICompany: 
            
                /* Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 * Example: public string Logo { get; set; }
                 */

            //In each of your Car, Truck, and SUV classes

                /* Create 2 members that are specific to each class
                 * Example for Car: public bool HasTrunk { get; set; }
                 * Example for SUV: public int NumberOfSeats { get; set; }
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car car = new Car() 
            {
                HasTrunk= true,
                HasFourWheelDrive = true,
                NumberOfWheels = 4,
                MilesPerGallon = 32,
                TypeOfEngine = "V8",
                NumberOfDoors = 4,
                Ceo = "Tony Bolognia",
                StockPrice = 120,

            };

            Truck truck = new Truck()
            {
                HasOpenBed = true,
                HasRadio = true,
                NumberOfWheels = 4,
                MilesPerGallon = 22,
                TypeOfEngine = "V8",
                NumberOfDoors = 2,
                Ceo = "Bigby Belly",
                StockPrice = 39,
            };

            SUV suv = new SUV()
            {
                NumberOfSeats = 8,
                HasTv = true,
                NumberOfWheels = 4,
                MilesPerGallon = 12,
                TypeOfEngine = "V8",
                NumberOfDoors = 4,
                Ceo = "Boy Howdy",
                StockPrice = 1999,
            };

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.
            car.DisplayDetails();
            Console.WriteLine("");
            truck.DisplayDetails();
            Console.WriteLine(" ");
            suv.DisplayDetails();
        }
    }
}
