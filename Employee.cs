//first name, last name and title all string
//Start date (DataTime)
using System;
namespace ClassExercise
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public Employee(string firstName, string lastName, string title, DateTime date)
        {
            FirstName = firstName;
            LastName = lastName;
            Title = title;
            Date = date;
        }
    }

}