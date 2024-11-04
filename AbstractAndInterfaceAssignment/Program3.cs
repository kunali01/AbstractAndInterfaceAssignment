using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//3.A company has employees and wants to keep a track of their names, id and hours of work.
//    The employees are specifically categorised into part-time and full-time. Salary needs to
//    be calculated for both however, where part-time employees get 200 rs.
//    Per hour and Full-time employees get 500 rs. per hour. Write a program which does the same.


abstract class Employee
{
    public string Name { get; set; }
    public int Id { get; set; }
    public int HoursWorked { get; set; }
    public abstract double CalculateSalary();
}

class FullTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return HoursWorked * 500;
    }
}

class PartTimeEmployee : Employee
{
    public override double CalculateSalary()
    {
        return HoursWorked * 200;
    }
}

class Program3
{
    //static void Main()
    //{
    //    List<Employee> employees = new List<Employee>
    //    {
    //        new FullTimeEmployee { Name = "Alice", Id = 1, HoursWorked = 40 },
    //        new PartTimeEmployee { Name = "Bob", Id = 2, HoursWorked = 20 }
    //    };

    //    foreach (var emp in employees)
    //    {
    //        Console.WriteLine($"{emp.Name} (ID: {emp.Id}) Salary: {emp.CalculateSalary()}");
    //    }
    //}
}

