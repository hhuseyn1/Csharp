namespace Client;
using Human;
using Credit;
class Client:Human{
    public string Live_Address { get; set; }
    public string Work_Address { get; set; }
    public Credit? Credit { get; set; }
    public Client(string name, string surname, int age, double salary, string live_address, string work_address) : base(name, surname, age, salary)
    {
        Live_Address = live_address;
        Work_Address = work_address;
    }

    public override string ToString()
    {
        return $@"{base.ToString()}
Live Address: {Live_Address}
Work Address: {Work_Address}";
}
}

