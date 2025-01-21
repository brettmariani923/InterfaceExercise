using System;

public class SUV : IVehicle, ICompany
{
    public int NumberOfSeats { get; set; }

    public bool HasTv { get; set; }

    
    public int NumberOfWheels {get; set;}

    public int MilesPerGallon {get; set; }

    public string TypeOfEngine { get; set; }

    public int NumberOfDoors {get; set;}


    public string Ceo { get; set; }

    public int StockPrice { get; set; }

    public void DisplayDetails()
   {
        Console.WriteLine($"Car Details:\n" +
        $"Wheels: {NumberOfWheels}, MPG: {MilesPerGallon}, Engine: {TypeOfEngine}, Doors: {NumberOfDoors}\n" +
        $"CEO: {Ceo}, Stock Price: {StockPrice}");
   }
}
