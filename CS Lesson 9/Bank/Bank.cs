using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Bank;
using CS_Lesson_9.Person;

internal class Bank
{
    private string? name;
    private decimal budget;
    public decimal Profit { get; set; }
    
    public string? Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Name must be written!");

            name = value;
        }
    }

    public decimal Budget
    {
        get { return budget; }
        set 
        {
            if (value < 5000)
                throw new ArgumentException("Bank Budget must be greater than 5000 AZN!");
            budget = value;
        }
    }

    CEO? _CEO { get; init; }





}
