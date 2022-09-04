using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;

class Client : Person
{
    private string? homeAddress;
    private string? workAddress;
    private double salary;

    public string? HomeAddress
    {
        get { return homeAddress; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Home Address must be written!");

            homeAddress = value;
        }
    }


    public string? WorkAddress
    {
        get { return workAddress; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Work Address must be written!");

            workAddress = value;
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


    public Client(string? name, string? surname, int age, string? homeAddress, string? workAddress, double salary)
    : base(name, surname, age)
    {
        HomeAddress = homeAddress;
        WorkAddress = workAddress;
        Salary = salary;
    }

    public override string ToString()
=> $@"{base.ToString()}
Home Address: {HomeAddress}
Work Address: {WorkAddress}
Salary: {Salary}";
}
