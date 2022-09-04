using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;

abstract class Person
{
    public readonly Guid Id;
    private string? name;
    private string? surname;
    private int age;

    public string? Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value)|| value.Length<3)
                throw new ArgumentException("Incorrect Name !");

            name = value;
        }
    }


    public string? Surname
    {
        get { return surname; }
        set
        {
            if (string.IsNullOrWhiteSpace(value)|| value.Length<3)
                throw new ArgumentException("Incorrect Surname !");
            surname = value;
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Incorrect Age !");
            age = value;
        }
    }




    protected Person(string? name, string? surname, int age)
    {
        Id=Guid.NewGuid();
        Name=name;
        Surname=surname;
        Age=age;
    }
    public override string ToString()
    => @$"ID: {Id}
Name: {Name}
Surname: {Surname}
Age: {Age}";




}
