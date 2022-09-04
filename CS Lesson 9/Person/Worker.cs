using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;
using CS_Lesson_9.Bank;
using CS_Lesson_9.Interface;

class Worker : Employee
{
    public TimeOnly StartTime { get; set; }
    public TimeOnly EndTime { get; set; }
    private List<Operation> Operations;


    public Worker(string? name, string? surname, int age, string? position, double salary, TimeOnly startTime, TimeOnly endTime)
: base(name, surname, age, position, salary)
    {
        StartTime = startTime;
        EndTime = endTime;
        Operations = new List<Operation>();
    }


    public void AddOperation(Operation op)
    {
        if (op == null)
            throw new ArgumentNullException();
        Operations.Add(op);
    }

    public void ShowOperations()
    {
        if (Operations.Count == 0)
            Console.WriteLine("EMPTY !");
        foreach (var op in Operations)
        {
            Console.WriteLine(op);
        }
    }

    public override void work() => Console.WriteLine("Worker Work !");

    public override string ToString()
=> @$"{base.ToString()}
Start Time: {StartTime}
End Time: {EndTime}";

}
