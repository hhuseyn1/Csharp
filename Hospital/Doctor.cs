namespace Doctor;
using Human;
using System.Collections.Generic;
class Doctor : Human {
    public int Id { get; set; }
    public string? Position { get;set;}
    public int ExperienceYear { get;set;}
    public List<string> AdmitionHours = new List<string>();
    public Doctor(int Id,string Name, string Surname, short Age, string Workaddress,string Position,int ExperienceYear) : base(Name, Surname, Age, Workaddress)
    {
    this.Id=Id;
    this.Position = Position;
    this.ExperienceYear = ExperienceYear;
    AdmitionHours.Add("9:00-11:00");
    AdmitionHours.Add("12:00-14:00");
    AdmitionHours.Add("15:00-17:00");
    }

    public override string ToString()
    {
return $@"{base.ToString()}
Id: {Id}
Position: {Position}
ExperienceYear: {ExperienceYear}
"; 
}



}
    
    

