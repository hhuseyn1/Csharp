namespace Bank;
using Client;
using Employee;
using Manager;
using Credit;
using CEO;

class Bank
{
    public string? Name { get; set; }
    public double Budget{ get; set; }
    public double Profit{ get; set; }
    public CEO? CEO { get; set; }
    public Manager? Manager { get; set; }
    public Client? Client { get; set; }


    List<Employee> Employees = new List<Employee>();
    List<Manager> Managers = new List<Manager>();
    List<Client> Clients = new List<Client>();

    public Bank(string Name, double Budget, double Profit)
    {
        this.Name = Name;
        this.Budget = Budget;
        this.Profit = Profit;
    }
    public Credit? ShowClientCredit(string name)
    {
        for (int i = 0; i < Clients.Count; i++)
        {
            if (Clients[i].Name == name)
                return Clients[i].Credit;
        }
                return null;
    }

    public string PayCredit(Client client, double money)
    {
        double debt=default;
        for (int i = 0; i < Clients.Count; i++)
        {
            if (Clients[i] == client)
            {
                Clients[i].Credit.Amount -= money;
                debt = Clients[i].Credit.Amount;
            }
        }
        return $"Your debt: {debt}";
    }

    public double ShowAllCredit()
    {
        double TotalCr=default;
        for (int i = 0; i < Clients.Count; i++)
        {
            TotalCr += Clients[i].Credit.Amount;
        }
        return TotalCr;
    }
}
