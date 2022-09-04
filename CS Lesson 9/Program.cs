namespace Lesson9;
using CS_Lesson_9.Interface;
using CS_Lesson_9.Person;
using CS_Lesson_9.Bank;

class Program
{
    static void Main()
    {
        CEO AliShamil = new("Ali", "Shamil", 18, "CEO", 2200);
        Bank AliBank = new("Bank Of Ali", AliShamil, 5000, 100000);

        Manager KenanM = new("Kenan", "Muradov", 18,"Manager", 1500);

        Worker Vasif = new("Vasif", "Babazade", 18, "Account Department", 600, new TimeOnly(8, 0), new TimeOnly(18, 0));
        Client Zahid = new("Zahid", "Nuhov", 18, "20-ci Sahe", "Fevvareler meydani", 350);
        Client Murad = new("Murad", "Kerbalayev", 19, "Kesle qesebesi", "28 May", 500);


        AliBank.AddWorker(Vasif);

        AliBank.AddWorker(KenanM);

        AliBank.AddClient(Murad);
        AliBank.AddClient(Zahid);


        AliBank.GiveCredit(Zahid, 400, 5, 18);


        AliBank.ShowClientCredit("Zahid Nuhov");

        
    }
}