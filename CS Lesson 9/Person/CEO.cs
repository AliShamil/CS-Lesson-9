using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Person;
using CS_Lesson_9.Interface;

class CEO : Employee, ICEO, IOrganize,IWorker
{


    public CEO(string? name, string? surname, int age, string? position, double salary)
    : base(name, surname, age, position, salary) { }


    public void control() => Console.WriteLine("CEO Control!");

    public void organize() => Console.WriteLine("CEO Organize!");

    public void makeMeeting() => Console.WriteLine("CEO make meeting!");

    public override void work() => Console.WriteLine("CEO Work!");
}
