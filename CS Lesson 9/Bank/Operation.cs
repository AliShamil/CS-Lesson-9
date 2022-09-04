using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Bank;

class Operation
{
    public readonly Guid Id;
    private string? process_name;


    public DateTime Time { get; set; }


    public string? ProcessName
    {
        get { return process_name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Process Name must be written!");

            process_name = value;
        }
    }

    public Operation(string? process_name, DateTime time)
    {
        Id=Guid.NewGuid();
        ProcessName=process_name;
        Time=time;
    }

    public override string ToString()
=> @$"ID: {Id}
Procces Name: {ProcessName}
Date Time: {Time}";
}
