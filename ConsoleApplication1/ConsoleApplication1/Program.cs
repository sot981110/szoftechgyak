using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Runnable
{
    class Program
    {
        static void Main(string[] args)
        {
            string maker;
            string type;
            int year;
            double motortype;
            string fueltype;
            double averageconsumption;

            int darab = 2;
            Car[] Cars = new Car[darab];

            for(int i = 1; i < 3; i++)
            {
                Console.WriteLine("Kerem a(z) {0}. auto gyartojat: ", i);
                maker = Console.ReadLine();
                Console.WriteLine("Kerem a(z) {0}. auto tipusat: ", i);
                type = Console.ReadLine();
                Console.WriteLine("Kerem a(z) {0}. auto gyartasi evet: ", i);
                year = int.Parse(Console.ReadLine());
                while(!(1998<=year && year <= 2018))
                {
                    Console.WriteLine("Újra: ");
                    year = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("Kerem a(z) {0}. auto motor tipusat: ", i);
                motortype = double.Parse(Console.ReadLine());
                Console.WriteLine("Kerem a(z) {0}. auto uzemanyag tipusat: ", i);
                fueltype = Console.ReadLine();
                Console.WriteLine("Kerem a(z) {0}. auto atlagos fogyasztasat: ", i);
                averageconsumption = double.Parse(Console.ReadLine());
                Cars[i-1] = new Car(maker, type, year, motortype, fueltype, averageconsumption);
            }

        }
    }
}
