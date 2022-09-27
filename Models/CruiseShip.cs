using System;

namespace ShipInformation.Models
{
    internal class CruiseShip : Ship
    {
        public override void Move()
        {
            Console.WriteLine("Starting all 112 engines");
            base.Move();
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping all 112 engines");
            base.Stop();
        }

        public override void BlowHorn()
        {
            System.Console.WriteLine("WAAAAAAAAOOOOOOO!");
        }
    }
}
