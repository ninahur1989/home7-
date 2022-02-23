using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home7
{
    abstract class Car : Vehicle
    {
        public override int MaxSpeed { get => (0); }
        public override int Price { get => (0); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine("but i can drive  ");
        }
    }
    class SportCar : Car
    {
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" SO fast \n");
        }
    }
    class MiddlePriceSportCar : SportCar
    {
        public override int MaxSpeed { get => (657); }
        public override int Price { get => (random.Next(50000, 300000)); }

    }
    class HighPriceSportCar : SportCar
    {
        public override int MaxSpeed { get => (799); }
        public override int Price { get => (random.Next(300000, 700000)); }
    }
    class FamilyCar : Car
    {
        public override int MaxSpeed { get => (60); }
        public override int Price { get => (random.Next(3000, 8000)); }
        public override void Opportunities()
        {
            base.Opportunities();
            Console.WriteLine(" SO slow \n");
        }
    }
}
