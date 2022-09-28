using System;
using ShipInformation.Models;

namespace ShipInformation
{
    internal static class Program
    {
        static void Main()
        {
            bool continueShipping = true;
            do
            {
                IShip ship = null;
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
                            ship = new SailBoat();
                            break;
                        case "3":
                        case "skiboat":
                        case "ski":
                            ship = new SkiBoat();
                            break;
                        default:
                            Console.WriteLine("ERROR: Invalid ship type selection.");
                            break;
                    }
                } while (ship is null);

                bool continueCommands = true;
                bool commandIsValid = true;
                do
                {
                    Console.WriteLine("What is your command, Captain?");
                    if (!commandIsValid)
                    {
                        Console.WriteLine("- Move - Stop - (Blow) Horn - Change (Ship) - End -");
                    }
                    Console.Write("» ");
                    string commandInput = Console.ReadLine().ToLower().Replace(" ", null);
                    switch (commandInput)
                    {
                        case "move":
                            commandIsValid = true;
                            ship.Move();
                            break;
                        case "stop":
                            commandIsValid = true;
                            ship.Stop();
                            break;
                        case "blowhorn":
                        case "horn":
                            commandIsValid = true;
                            ship.BlowHorn();
                            break;
                        case "changeship":
                        case "change":
                            commandIsValid = true;
                            continueCommands = false;
                            break;
                        case "end":
                            commandIsValid = true;
                            continueCommands = false;
                            continueShipping = false;
                            break;
                        default:
                            commandIsValid = false;
                            Console.WriteLine("ERROR: Invalid command.");
                            break;
                    }
                } while (continueCommands);
            } while (continueShipping);

            Console.ReadKey(intercept: true);
        }
    }
}
