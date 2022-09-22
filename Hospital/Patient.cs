namespace Patient;
using Human;
class Patient : Human
{
    public short BloodGroup { get; set; }
    public string? Phone { get; set; }
    public bool? hasInsurance { get; set; }
    public Patient(string Name, string Surname, short Age, string Workaddress, short BloodGroup,string Phone) : base(Name, Surname, Age, Workaddress)
    {
        this.BloodGroup = BloodGroup;
        this.Phone = Phone;

    }

    public override string ToString()
    {
        return @$"{base.ToString()}
Phone: {Phone}
Bloog : {BloodGroup}
Insurance: {hasInsurance}";
}

}
    
    

