using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home7
{
    public abstract class Vehicle: IComparable
    {
        public abstract int MaxSpeed { get; }
        public abstract int Price { get; }

        public Random random = new Random();
        virtual public void Opportunities()
        {
            Console.WriteLine("i'm not alive ");
        }
        public int CompareTo(object o)
        {
            Vehicle p = o as Vehicle;
            if (p != null)
            {
                return this.Price.CompareTo(p.Price);
            }
            else
                throw new Exception("error");
        }
    }

    class Airplane : Vehicle
    {
        public override int MaxSpeed { get => (random.Next(900, 1000)); }
        public override int Price { get => (random.Next(25000, 100000)); }
        
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can fly \n");
        }
    }

    class Boat : Vehicle
    {
        public override int MaxSpeed { get => (random.Next(100, 300)); }
        public override int Price { get => (random.Next(4000, 30000)); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can swim \n ");
        }
    }
}
