using System;

public class Truck : ICompany, IVehicle
{
    public bool HasOpenBed { get; set; }

    public bool HasRadio { get; set; }


    public int NumberOfWheels {get; set;}

    public int MilesPerGallon {get; set; }

    public string TypeOfEngine { get; set; }

    public int NumberOfDoors {get; set;}


    public string Ceo { get; set; }

    public int StockPrice { get; set; }

    public void DisplayDetails()
   {
        Console.WriteLine($"Truck Details:\n" +
        $"Wheels: {NumberOfWheels}, MPG: {MilesPerGallon}, Engine: {TypeOfEngine}, Doors: {NumberOfDoors}\n" +
        $"CEO: {Ceo}, Stock Price: {StockPrice}");
   }
}