using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;

abstract class Employee : Person
{
    private string? position;
    private double salary;

    public string? Position
    {
        get { return position; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Position must be written!");

            position = value;
        }
    }

    public double Salary
    {
        get { return salary; }
        set
        {
            if (value<0)
                throw new ArgumentException("Incorrect Salary !");
            salary = value;
        }
    }



    public Employee(string? name, string? surname, int age, string? position, double salary)
        : base(name, surname, age)
    {
        Name=name;
        Surname=surname;
        Age=age;
        Position=position;
        Salary=salary;
    }

    public override string ToString()
    => $@"{base.ToString()}
Position: {Position} 
Salary: {Salary} AZN";

}
