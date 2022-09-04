using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;
using CS_Lesson_9.Interface;
class Manager : Employee, IOrganize, IManager
{
    public Manager(string? name, string? surname, int age, string? position, double salary)
: base(name, surname, age, position, salary) { }



    public double calculateSalaries(List<Worker> workers)
    {
        double sum = 0;

        if (workers is null)
            throw new ArgumentNullException();

        foreach (var worker in workers)
        {
            sum+=worker.Salary;
        }

        return sum;
    }


    public void organize() => Console.WriteLine("Manager Organize !");
}
