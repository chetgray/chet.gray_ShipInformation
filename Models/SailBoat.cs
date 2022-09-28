using System;

namespace ShipInformation.Models
{
    internal class SailBoat : Ship
    {
        public override void Move()
        {
            Console.WriteLine("Raising sails");
            base.Move();
        }

        public override void Stop()
        {
            Console.WriteLine("Lowering sails");
            base.Stop();
        }

        public override void BlowHorn()
        {
            Console.WriteLine("Toot!");
        }
    }
}
