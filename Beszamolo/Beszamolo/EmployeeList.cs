using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beszamolo
{
    class EmployeeList
    {
        private List<Employee> employees;

        public void NewEmployee(Employee employee)
        {
            foreach (Employee em in employees)
            {
                if(employee.Name == em.Name)
                {
                    return;
                }
            }
            employees.Add(employee);
            return;
        }

        public int CountEmployees()
        {
            return employees.Count;
        }

        public Employee SearchName(string name)
        {
            foreach(Employee em in employees)
            {
                if (em.Name == name)
                {
                    return em;
                }
            }
            return null;
        }

        public void RemoveEmployee(string name)
        {
            foreach(Employee em in employees)
            {
                if(em.Name == name)
                {
                    employees.Remove(em);
                }
            }
            return;
        }

        public Employee BestEmployee()
        {
            Employee em1 = employees.ElementAt(0);
            foreach(Employee em2 in employees)
            {
                em1 = Employee.EmployeeComparison.CompareEmployees(em1, em2);
            }
            return em1;
        }


    }
}
