using System.Reflection.Metadata.Ecma335;

namespace Storage;

abstract class Storage {
    public string? MediaName { get; set; }
    public string? Model { get; set; }

    public double Memory { get; set; }
    public double UsedMemory { get; set; }
    public Storage(string MediaName,string Model,double Memory,double UsedMemory)
    {
        this.MediaName = MediaName;
        this.Model= Model;
        this.Memory= Memory;
        this.UsedMemory= UsedMemory;
    }

    public  double FreeMemory() { return Memory - UsedMemory; }
    public double TotalMemory() { return Memory; }
    public override string ToString(){
return @$"Media Name: {MediaName}
Model: {Model}
Total memory: {Memory} Gb
Available memory: {FreeMemory()} Gb
";
}

}
