namespace Main;
using Bank;
using CEO;
using Client;
using Credit;
using Employee;
using Human;
using Manager;
using Operation;

interface IControl
{
    void Control();
}

interface IOrganizer
{
    void Organize();
}
interface IMakeMeeting
{
    void MakeMeeting();
}

interface ICalculateSalaries
{
    void CalculateSalaries();
}

interface IDecreasePersentage
{
    void DecreasePersentage();
}
class Program
{
    static void Main()
    {
        CEO ceo = new("Huseyn","Hemidov",18,1800,"CEO");
        Client client = new("John","John",39,2000,"Settar Behlulzade 1","Koroghlu Rahimov 70");
        Credit credit = new(client,12000,3,24);
        Manager manager = new("Josep","Clarke",26,1300,"Main Manager");
        Bank bank = new Bank("HBank",83609345,1234532);
        bank.CEO = ceo;
        bank.Manager = manager;
        bank.Client = client;
    }
}