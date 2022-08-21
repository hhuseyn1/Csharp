using System;
using System.Threading;

namespace Bank;

class BankCard
{
public string? PAN { get; set; }
public string? PIN { get; set; }
public int CVC { get; set; }
public short ExpireMonth { get; set; }
public short ExpireYear { get; set; }
public double Balance { get; set; }

public BankCard() { }

public BankCard(string? PAN, string? PIN, int CVC, short ExpireMonth,short ExpireYear, double Balance)
{
    this.PAN = PAN;
    this.PIN = PIN;
    this.CVC = CVC;
    this.ExpireMonth = ExpireMonth;
    this.ExpireYear = ExpireYear;
    this.Balance = Balance;
}
    public override string ToString()
    {
return @$"---------------------------
Pan:{PAN}
Pin:{PIN}
Expire Date:{ExpireMonth}/{ExpireYear} 
Balance:{Balance}
---------------------------"; 
    }
}


class Client
{
public string? Name { get; set; }
public string? Surname { get; set; }
public string? WorkPlace { get; set; }
public BankCard? Card { get; set; }

public Client() { }

public Client(string? Name, string? Surname, string? WorkPlace,BankCard Card)
{
this.Name = Name;
this.Surname = Surname;
this.Card = Card;
this.WorkPlace = WorkPlace;
}

public override string ToString()
{
return @$"Name Surname:{Name} {Surname}
Workplace:{WorkPlace}
Pan:{Card?.PAN}
Pin:{Card?.PIN}
Expire Date:{Card?.ExpireMonth}/{Card?.ExpireYear}
Balance:{Card?.Balance}";
}
}

class Bank
{
    public string? Address { get; set; }
    Client[]? clients;
    public Bank() { }
    public Bank(Client[] clients, string Address)
    {
        this.clients = clients;
        this.Address = Address;
    }
    public void ShowAllClients()
    {
        for (int i = 0; i < clients?.Length; i++)
        {
            Console.WriteLine(clients[i].ToString());
        }
    }
    public override string? ToString()
    {

        Console.WriteLine("Bank info");
        Console.WriteLine("---------Clients---------");
        for (int i = 0; i < clients?.Length; i++)
        {
            Console.WriteLine($"{clients[i].Name} {clients[i].Surname}");
        }
        Console.WriteLine("-------------------------");
        return $"Address:{Address}";
    }
    class Program
    {
        static void Main()
        {
            bool isRuning=true;
            string? choice;
            string? check;
            string? choice2;
            double money = default;
            Random random = new();
            BankCard bc1 = new("1234 5678 9101 1121", "1234", random.Next(), 9, 2022, random.Next(1, 1000));
            BankCard bc2 = new("1234 9101 1121 5678 ", "4567", random.Next(), 2, 2023, random.Next(1, 1000));
            BankCard bc3 = new("1121 1234 5678 9101 ", "7890", random.Next(), 4, 2024, random.Next(1, 1000));
            Client c1 = new("Huseyn", "Hemidov", "StepIt", bc1);
            Client c3 = new("Tomas", "Frazier", "Apple", bc2);
            Client c2 = new("Michael", "Bloom", "Microsoft", bc3);
            Client[] clients =
            {
            c1,c2,c3
        };
            Bank b = new(clients, "Koroglu Rahimov 70");
                Console.WriteLine("Enter your PIN: ");
                check = Console.ReadLine();
            Console.Clear();

            while (isRuning)
            {
                for (int i = 0; i < clients?.Length; i++)
                {
                    if (check == clients[i]?.Card?.PIN)
                    {
                        Console.WriteLine($"Welcome {clients[i].Name} {clients[i].Surname} !!!");
                        Console.WriteLine("[1]Balance");
                        Console.WriteLine("[2]Cash");
                        choice = Console.ReadLine();
                        switch (choice)
                        {
                            case "1":
                                Console.WriteLine($"{clients[i]?.Card?.Balance-money} Azn");
                                Thread.Sleep(1000);
                                Console.Clear();
                                break;
                            case "2":

                                Console.WriteLine(@"[1]10 Azn
[2]20 Azn
[3]50 Azn
[4]100 Azn
[5]Choose");
                                choice2 = Console.ReadLine();
                                Console.Clear();
                                switch (choice2)
                                {
                                    case "1":

                                        money += 10;
                                        break;
                                    case "2":
                                        money += 20;

                                        break;
                                    case "3":
                                        money += 50;

                                        break;
                                    case "4":
                                        money += 100;

                                        break;
                                    case "5":
                                        Console.WriteLine("Enter amount: ");
                                        money += Console.Read();

                                        break;
                                    default:
                                        break;
                                }

                                break;
                            default:
                                break;
                        }
                        if (money > clients[i]?.Card?.Balance)
                            throw new Exception("Balance isn't enough");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid PIN");
                        System.Environment.Exit(0);
                    }
                }
            }

        }


    }
}