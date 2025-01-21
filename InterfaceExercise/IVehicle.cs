using System;

public interface IVehicle : ICompany
{
    public int NumberOfWheels { get; set; }

    public int NumberOfDoors { get; set; }

    public string TypeOfEngine { get; set; }

    public int MilesPerGallon { get; set; }

    public void DisplayDetails()
    {
        throw new System.NotImplementedException();
    }
    
}