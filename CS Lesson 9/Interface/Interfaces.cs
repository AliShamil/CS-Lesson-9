using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Interface;
using CS_Lesson_9.Person;

interface ICEO
{
    void control();
    void makeMeeting();
}

interface IWorker
{
    void work();
}

interface IManager
{
    double calculateSalaries(List<Worker> workers);
}

interface IOrganize
{
    void organize();
}
