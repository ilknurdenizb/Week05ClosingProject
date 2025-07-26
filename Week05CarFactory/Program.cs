using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using Week05CarFactory;
class Program
{
    static void Main()
    {   
        List<Cars> carlist = new List<Cars>(); // List to store produced cars

        string answer;
        while (true) // Loop to continuously ask the user if they want to produce a car
        {   // ask the user if they want to produce a car
            Console.WriteLine("Would you like to produce a car? (y/n)");
            answer = Console.ReadLine()?.ToLower();

            if (answer == "y")
            {
                // produce a new car
                Console.WriteLine("Producing a new car...");
                
                
                    Console.Write("Enter your brand: ");
                    string brand = Console.ReadLine();

                    Console.Write("Enter your model: ");
                    string model = Console.ReadLine();

                    Console.Write("Enter your color: ");
                    string color = Console.ReadLine();

                    Console.Write("Enter your door count: ");
                    int doorCount;


            // Input control for door count, only 2 or 4 are allowed
            doorInput:     // Using a label to allow for re-prompting if the input is invalid
                Console.Write("Enter door count (only numbers like 2 or 4): ");
                    string doorInputStr = Console.ReadLine();

                    if (!int.TryParse(doorInputStr, out doorCount))
                    {
                        Console.WriteLine("Invalid input! Please enter a valid number.");
                        goto doorInput;
                    }

                    // 2 and 4 input control
                    if (doorCount != 2 && doorCount != 4)
                    {
                        Console.WriteLine("Only 2 or 4 doors are allowed.");
                        goto doorInput;
                    }

                    Cars newCar = new Cars(brand, model, color, doorCount, carlist.Count + 1);
                    carlist.Add(newCar);

                Console.WriteLine($"Car produced successfully!");
                Console.WriteLine($"Serial Number: {newCar.SerialNumber}");
                Console.WriteLine($"Production Date: {newCar.ProductionDate}\n");
            }


            // Ask the user if they want to produce another car
            else if (answer == "n")
            {
                Console.WriteLine("\nExiting the program...");
                Console.WriteLine("\nProduced Cars List:");
                // Display the list of produced cars
                foreach (var car in carlist)
                {
                    Console.WriteLine($"Serial Number: {car.SerialNumber}, Brand: {car.Brand}");
                }
                break;
            }
            // If the input is neither 'y' nor 'n', prompt the user again
            else
            {
                Console.WriteLine("Your input is invalid! Please enter only 'y' or 'n'.");
                continue; // returns to the start of the loop to ask again
            }
        }
    }
}