using System;
using System.Collections.Generic;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of a company. Name it whatever you like.
            Company UBS = new Company("UBS", new DateTime(1989, 09, 23));

            // Create three employees
            Employee maggie = new Employee("Maggie", "Jonathan", "Assistant Manager", new DateTime(1989, 05, 28));
            Employee lediya = new Employee("Lediya", "Bedru", "Clerk", new DateTime(1989, 02, 05));
            Employee bini = new Employee("Bini", "Daniel", "Manager", new DateTime(1989, 07, 22));


            // Assign the employees to the company
            UBS.CurrentEmployees = new List<Employee>() { maggie, lediya, bini };

            /*
                Iterate the company's employee list and generate the
                simple report shown above
            */
            foreach (Employee person in UBS.CurrentEmployees)
            {
                Console.WriteLine($"{person.FirstName} {person.LastName} works for UBS as {person.Title}.");
            }
        }
    }

}
