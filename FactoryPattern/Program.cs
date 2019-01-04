using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is the starting...
            Console.WriteLine("Enter the car name");

            string carName = Console.ReadLine();


            AutoFactory autoFactory = new AutoFactory();

            IAuto car = autoFactory.CreateInstance(carName);

            car.On();

            car.Off();

            Console.ReadLine();
        }
    }
}
