using System;
using System.Collections.Generic;

// Base class representing a vehicle
public class Vehicle
{
    protected string brand;
    protected string model;

    // Constructor to initialize brand and model
    public Vehicle(string brand, string model)
    {
        this.brand = brand;
        this.model = model;
    }

    // Method to display information about the vehicle
    public virtual string DisplayInfo()
    {
        return $"{brand} {model}";
    }
}

// Derived class representing a car
public class Car : Vehicle
{
    // Constructor for Car, invoking base class constructor
    public Car(string brand, string model) : base(brand, model)
    {
    }
}

// Derived class representing a truck
public class Truck : Vehicle
{
    // Constructor for Truck, invoking base class constructor
    public Truck(string brand, string model) : base(brand, model)
    {
    }
}

class Program
{
    static void Main()
    {
        // Create a list to hold the fleet of vehicles
        List<Vehicle> vehicleFleet = new List<Vehicle>();

        Console.WriteLine("Welcome to the Vehicle Fleet Manager!");

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Add a Car to the Fleet");
            Console.WriteLine("2. Add a Truck to the Fleet");
            Console.WriteLine("3. Display Fleet Information");
            Console.WriteLine("4. Exit");

            // Get user input
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter the brand of the Car: ");
                    string carBrand = Console.ReadLine();
                    Console.Write("Enter the model of the Car: ");
                    string carModel = Console.ReadLine();
                    Car car = new Car(carBrand, carModel);
                    vehicleFleet.Add(car);
                    Console.WriteLine($"{carBrand} {carModel} has been added to the fleet!");
                    break;

                case "2":
                    Console.Write("Enter the brand of the Truck: ");
                    string truckBrand = Console.ReadLine();
                    Console.Write("Enter the model of the Truck: ");
                    string truckModel = Console.ReadLine();
                    Truck truck = new Truck(truckBrand, truckModel);
                    vehicleFleet.Add(truck);
                    Console.WriteLine($"{truckBrand} {truckModel} has been added to the fleet!");
                    break;

                case "3":
                    Console.WriteLine("\nVehicles in the Fleet:");
                    foreach (Vehicle vehicle in vehicleFleet)
                    {
                        Console.WriteLine(vehicle.DisplayInfo());
                    }
                    break;

                case "4":
                    Console.WriteLine("Exiting the Vehicle Fleet Manager. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }
}
