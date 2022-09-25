namespace Hospital;
using Patient;
using Doctor;

interface IModule
{
    void Module();
}
class Hospital:IModule
{
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public Hospital(string Location, string Phone)
    {
        this.Location = Location;
        this.Phone = Phone;

    }
    public void Module()
    {
        Console.WriteLine("Hospital can be module hospital in quarantine");
    }
    
    public override string ToString()
    {
        return @$"---- Hospital ----
Location: {Location}
Phone: {Phone}
";}

}