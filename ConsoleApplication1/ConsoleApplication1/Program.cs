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
            double motorType;
            string fuelType;
            double averageConsumptuion;

            int darab = 2;
            Car[] Cars = new Car[darab];

            for(i = 1; i < 3; int++)
            {
                Console.WriteLine("Kerem a(z) {0}. auto gyartojat: ", i);
                maker = Console.ReadLine();
                Console.WriteLine("Kerem a(z) {0}. auto tipusat: ", i);
                type = Console.ReadLine();
                Console.WriteLine("Kerem a(z) {0}. auto gyartasi evet: ", i);
                while(!(1998<=year && year <= 2018))
                {
                    Console.WriteLine("Újra: ");
                    
                }
            }


        }
    }
}
