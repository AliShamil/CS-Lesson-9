using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Lesson_9.Bank;
using CS_Lesson_9.Person;
using CS_Lesson_9.Interface;

internal class Bank
{
    private string? name;
    private double budget;
    public double Profit { get; set; }
    
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

    public double Budget
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

    List<IWorker>? Workers;
    
    List<Client>? Clients;

    List<Credit>? Credits;

    public Bank(string? name, CEO? ceo, double profit,  double budget)
    {
        Name=name;
        _CEO=ceo;
        Profit=profit;
        Budget=budget;
        Workers = new List<IWorker>();
        Clients = new List<Client>();
        Credits = new List<Credit>();
    }

    public void AddWorker(IWorker worker)
    {
        if (worker is null)
        {
            Console.WriteLine("Incorrect Worker!");
            return;
        }

        Workers?.Add(worker);
    }

    public void AddCredit(Credit credit)
    {
        if (credit is null)
        {
            Console.WriteLine("Incorrect Credit!");
            return;
        }

        Credits?.Add(credit);
    }

    public void AddClient(Client client)
    {
        if (client is null)
        {
            Console.WriteLine("Incorrect Client!");
            return;
        }

        Clients?.Add(client);
    }

    public void ShowClientCredit(string? fullname)
    {
        var Full = fullname?.Split(' ');
        

        if (Full?.Length <= 1)
        {
            Console.WriteLine("Wrong Info");
            return;
        }
        string firstName = Full![0];
        string lastName = Full[1];

        foreach (var credit in Credits!)
        {
            if (credit._Client?.Name?.ToLower() == firstName.ToLower() && credit._Client?.Surname?.ToLower() == lastName.ToLower())
            {
                Console.WriteLine(credit);
                return;
            }
        }

        Console.WriteLine("Wronng Info!");
    }



    public void PayCredit(Client client, double money)
    {

        if(!Clients.Contains(client))
        { 
            Console.WriteLine($"{client.Name} you are not our client! (Pls add yourself to our clients)");
            return;
        }


        if (money <= 0)
        {
            Console.WriteLine("Incorrect Money!");
            return;
        }

        foreach (var credit in Credits!)
        {
            if (credit?._Client == client)
            {
                credit.Amount -= money;
                return;
            }
        }

        Console.WriteLine("Wrong Info");
    }

    public void GiveCredit(Client client, double amount,double percent,short months)
    {

        if (!Clients.Contains(client))
        {
            Console.WriteLine($"{client.Name} you are not our client! (Pls add yourself to our clients)");
            return;
        }

        if (amount <= 0 || amount>= (Budget/2) )
        {
            Console.WriteLine("Incorrect Money!");
            return;
        }

        Credit newCredit = new(client, amount, percent, months);

        if (newCredit.Percent > (client?.Salary/2))
            throw new ArgumentException("Your salary is not enough for this amount!");

        
        Credits?.Add(newCredit);
    }




    public void ShowAllCredits()
    {
        if (Credits?.Count==0)
        {
            Console.WriteLine("There are no credits yet!");
            return;
        }

        Console.WriteLine("\t\t\t\t\t========  Credits  ========");

        foreach (var credit in Credits!)
            Console.WriteLine(credit);
    }
}
