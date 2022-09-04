using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Bank;
using CS_Lesson_9.Person;

internal class Credit
{
    public readonly Guid Id;
    public Client? _Client { get; set; }
    public readonly double Payment;
    private double amount;
    private double percent;
    private short months;


    public double Amount
    {
        get { return amount; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Incorrect Amount !");

            amount = value;
        }
    }

    public double Percent
    {
        get { return percent; }
        set
        {
            if (value < 0)
                throw new ArgumentException("Incorrect percent !");

            percent = value;
        }
    }

    public short Months
    {
        get { return months; }
        set
        {
            if (value < 3 || value > 48)
                throw new ArgumentException("Incorrect (3 - 48)");

            months = value;
        }
    }

    public Credit(Client? client, double amount, double percent, short months)
    {
        Id = Guid.NewGuid();
        _Client=client;
        Amount=amount;
        Percent=percent;
        Months=months;
        Payment= (Amount + calculatePercent())/Months;
    }

    public double calculatePercent() => amount / 100 * percent;


    public override string ToString()
=> $@"ID: {Id}

Client: {_Client}
Amount: {Amount} AZN
Percent: {Percent} %
Months: {Months}
Payment: {Payment} AZN";

}
