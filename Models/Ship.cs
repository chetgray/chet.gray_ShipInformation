using System;

namespace ShipInformation.Models
{
    internal abstract class Ship
    {
        public virtual void Move()
        {
            Console.WriteLine("The ship has started to move.");
        }

        public virtual void Stop()
        {
            Console.WriteLine("The ship has stopped.");
        }

        public abstract void BlowHorn();
    }
}
