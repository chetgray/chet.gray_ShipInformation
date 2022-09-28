using System;
using ShipInformation.Models;

namespace ShipInformation
{
    internal static class Program
    {
        static void Main()
        {
            Ship ship = null;

            do
            {
                Console.Write(
                    "What type of ship are you running?\n"
                        + "- [1] Cruise Ship - [2] Sail Boat - [3] Ski Boat -\n» "
                );
                string shipInput = Console.ReadLine().ToLower().Replace(" ", null);
                switch (shipInput)
                {
                    case "1":
                    case "cruiseship":
                    case "cruise":
                        ship = new CruiseShip();
                        break;
                    case "2":
                    case "sailboat":
                    case "sail":
                    case "3":
                    case "skiboat":
                    case "ski":
                    default:
                        Console.WriteLine("ERROR: Invalid ship type selection.");
                        break;
                }
            } while (ship is null);

            Console.ReadKey(intercept: true);
        }
    }
}
