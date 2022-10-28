using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillTest
{
    public class EmployeesManagement
    {
        public static Dictionary<string, int> AverageAgeForEachCompany(List<Employee> employees)
        {
            return SortDictionaryByCompany(employees).ToDictionary(grp => grp.Key, grp => (int) Math.Round(grp.Average(e => e.Age), MidpointRounding.AwayFromZero));
        }

        public static Dictionary<string, int> CountOfEmployeesForEachCompany(List<Employee> employees)
        {
            return SortDictionaryByCompany(employees).ToDictionary(grp => grp.Key, grp => grp.Count());
        }

        public static Dictionary<string, Employee> OldestAgeForEachCompany(List<Employee> employees)
        {
            return SortDictionaryByCompany(employees).ToDictionary(grp => grp.Key, grp => employees.Where(p => p.Company == grp.Key && p.Age == (int)grp.Max(e => e.Age)).FirstOrDefault());
        }

        private static IEnumerable<IGrouping<string, Employee>> SortDictionaryByCompany(List<Employee> employees)
        {
            return employees.Distinct().GroupBy(e => e.Company).OrderBy(e => e.Key);
        }

        public static void Main()
        {
            int countOfEmployees = int.Parse(Console.ReadLine());

            var employees = new List<Employee>();

            for (int i = 0; i < countOfEmployees; i++)
            {
                string str = Console.ReadLine();
                string[] strArr = str.Split(' ');
                employees.Add(new Employee
                {
                    FirstName = strArr[0],
                    LastName = strArr[1],
                    Company = strArr[2],
                    Age = int.Parse(strArr[3])
                });
            }

            foreach (var emp in AverageAgeForEachCompany(employees))
            {
                Console.WriteLine($"The average age for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in CountOfEmployeesForEachCompany(employees))
            {
                Console.WriteLine($"The count of employees for company {emp.Key} is {emp.Value}");
            }

            foreach (var emp in OldestAgeForEachCompany(employees))
            {
                Console.WriteLine($"The oldest employee of company {emp.Key} is {emp.Value.FirstName} {emp.Value.LastName} having age {emp.Value.Age}");
            }
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Company { get; set; }
    }
}
