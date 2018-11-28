using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Beszamolo
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("beolvasando.txt", true);
            EmployeeList employed = new EmployeeList();
            string[4] strings;
            Employee employee;

            while (reader.EndOfStream == false)
            {
                strings = reader.ReadLine().Split(',');
                employee = new Employee(strings[0], int.Parse(strings[1]), int.Parse(strings[2]), strings[3]);
                employed.NewEmployee(employee); 
            }

            Console.WriteLine(employed.BestEmployee());
        }
    }
}
