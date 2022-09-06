namespace Credit;
using Client;
class Credit {
    public Guid Id { get; set; }= Guid.NewGuid();
    public Client? Client { get; set; }

    public double Amount { get; set; }
    public int Percent { get; set; }
    public  int Months { get; set; }

    public double Payment { get; set; }

    public Credit(Client Client, double Amount, int Percent, int Months)
    {
        this.Client = Client;
        this.Amount = Amount;
        this.Percent = Percent;
        this.Months = Months;
        Payment = CalculatePayment();
    }

    public double CalculatePayment()
    {
        return (Amount * Percent) / 100;
    }

    public override string ToString() { 
        return $@"Id: {Id}
Client: {Client}
Amount: {Amount}
Percent: {Percent}
Months: {Months}
Payment: {Payment}";
    }
}

    

