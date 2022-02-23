using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home7
{
    internal class Starter
    {
        public void Run()
        {
            Vehicle vehicle1 = new Airplane();
            Vehicle vehicle2 = new Boat();
            Vehicle vehicle3 = new FamilyCar();
            Vehicle vehicle4 = new MiddlePriceSportCar();
            Vehicle vehicle5 = new HighPriceSportCar();
            Vehicle[] vehicles = new Vehicle[] { vehicle1 , vehicle2 , vehicle3 , vehicle4 , vehicle5};
            Array.Sort(vehicles);

            while (true)
            {
                Console.WriteLine($"Write for speed/price do you want a filter list OR write 'all' to see all our AVTOPARK ");
                string choise = Console.ReadLine();
                if(string.IsNullOrEmpty(choise))
                {
                    Console.WriteLine("it isnt a right string !!!");
                    continue;
                }

                switch (choise.ToLower())
                {
                    case "speed":
                        Choise2(vehicles);
                        break;
                    case "price":
                        Choise1(vehicles);
                        break;
                    case "all":
                        Console.Clear();
                        foreach (Vehicle vivod in vehicles)
                        {
                            Console.WriteLine(vivod.GetType().Name);
                            Console.WriteLine($" have price: {vivod.Price} and status:");
                            vivod.Opportunities();
                        }
                        break;
                }
            }
        }
        public void Choise1(Vehicle[] array)
        {
            int max;
            int min;

            while (true)
            {
                Console.WriteLine("write  min value");
                if (!int.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }
                Console.WriteLine("write  max value");
                if (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }
                if (max < min)
                    continue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].Price > min && array[i].Price < max)                   
                        Console.WriteLine($"{array[i].GetType().Name} have price : {array[i].Price} and speed: {array[i].MaxSpeed}  \n"); 
                }
                break;
            }
        }
        public void Choise2(Vehicle[] array)
        {
            int max;
            int min;

            while (true)
            {
                Console.WriteLine("write  min value");
                if (!int.TryParse(Console.ReadLine(), out min))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }
                Console.WriteLine("write  max value");
                if (!int.TryParse(Console.ReadLine(), out max))
                {
                    Console.WriteLine("it isnt number!!");
                    continue;
                }
                if (max < min)
                    continue;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i].MaxSpeed > min && array[i].MaxSpeed < max)
                    {
                        Console.WriteLine($"{array[i].GetType().Name} have speed : {array[i].MaxSpeed} and price: {array[i].Price} \n ");

                    }
                }
                break;

            }
        }
    }
}

