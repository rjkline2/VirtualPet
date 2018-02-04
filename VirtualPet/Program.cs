using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class Program
    {
        static void Main(string[] args)
        {
            //nteractive user interface 
            //Display current status of pet
            //Display options for interacting with pet
            //Ask user what action to take
            int userChoice;

            VirtualPet userVirtualPet = new VirtualPet(7, 5, 0, 0);

            do
            {

                Console.WriteLine(" ");
                Console.WriteLine("Hello, welcome to the Virtual Pet app.");
                Console.WriteLine("What would you like to do with your pet?");
                Console.WriteLine("To feed it, type 1");
                Console.WriteLine("To give it water, type 2");
                Console.WriteLine("To check it's status 3");
                Console.WriteLine("To quit, type, type 4");

                userChoice = int.Parse(Console.ReadLine());
                userVirtualPet.Tick();
                


                switch (userChoice)
                {
                    case 1:
                        Console.WriteLine("Currently the lil' beast is: " + userVirtualPet.Hunger);
                        Console.WriteLine("How much food do you want to give it? Whole numbers only, between 1-100");
                        int foodAdded = int.Parse(Console.ReadLine());
                        userVirtualPet.AddFood(foodAdded);
                        Console.WriteLine("Here is the beast's current hunger level:" + userVirtualPet.Hunger);
                        break;
                    case 2:
                        Console.WriteLine("Currently the lil' beast's thirst level is: " + userVirtualPet.Thirst);
                        Console.WriteLine("How much water do you want to give it? Whole numbers only, between 1-100");
                        int waterAdded = int.Parse(Console.ReadLine());
                        userVirtualPet.AddWater(waterAdded);
                        Console.WriteLine("Here is the beast's current water level:" + userVirtualPet.Thirst);
                        break;
                    case 3:
                        Console.WriteLine("The beast is currently:");
                        Console.WriteLine("Hunger level: " + userVirtualPet.Eat());
                        Console.WriteLine("Thirst level: " + userVirtualPet.Drink());
                        break;
                    default:
                        break;
                }

            } while (userChoice != 4);






































        }






    }
}

