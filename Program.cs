﻿using System;
using ShipInformation.Models;

namespace ShipInformation
{
    internal static class Program
    {
        static void Main()
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
            do
            {
                Console.Write("What is your command, Captain?\n» ");
                string commandInput = Console.ReadLine().ToLower().Replace(" ", null);
                switch (commandInput)
                {
                    case "move":
                        ship.Move();
                        break;
                    case "stop":
                        ship.Stop();
                        break;
                    case "blowhorn":
                    case "horn":
                        ship.BlowHorn();
                        break;
                    case "changeship":
                    case "change":
                    case "end":
                        continueCommands = false;
                        break;
                    default:
                        Console.WriteLine("ERROR: Invalid command.");
                        break;
                }
            } while (continueCommands);

            Console.ReadKey(intercept: true);
        }
    }
}
