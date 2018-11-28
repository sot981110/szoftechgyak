using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beszamolo
{
    
    class Employee
    {
        

        private string name;
        private int payment;
        private int nofyears;
        private Rank rank;

        public enum Rank
        {
            JUNIOR, SENIOR, MANAGER
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Payment
        {
            get
            {
                return payment;
            }

            set
            {
                payment = value;
            }
        }

        public int Nofyears
        {
            get
            {
                return nofyears;
            }

            set
            {
                nofyears = value;
            }
        }

        private Rank Rank1
        {
            get
            {
                return rank;
            }

            set
            {
                rank = value;
            }
        }

        public Employee(string name, int payment, int nofyears, Rank rank)
        {
            this.Name = name;
            this.Nofyears = nofyears;
            this.Payment = payment;
            this.Rank1 = rank;
        }

        public override string ToString()
        {
            return Name + " " + Payment + " " + Nofyears + " " + Rank1;
        }

        public static class EmployeeComparison
        {
            public static Employee CompareEmployees(Employee employee1, Employee employee2)
            {
                if((employee1.Payment/employee1.Nofyears) > (employee2.Payment / employee2.Nofyears))
                {
                    return employee1;
                }
                else
                {
                    return employee2;
                }
            }
        }


    }
}
