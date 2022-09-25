namespace Patient;
using Human;
using Main;

class Patient : Human
{
    public string? bloodgroup;
    List<string> bloodgroups = new List<string>();
    List<string> numbers= new List<string>();
    
    public string? BloodGroup { get { return bloodgroup; } 
        set{
            foreach (var bloodgroupch in bloodgroups)
            {
                if (BloodGroup != bloodgroupch)
                    throw new ArgumentOutOfRangeException("Invalid blood group");
            }         
        }
    }
    public string? phone;
    public string? Phone { get { return phone; } 
        set {
            if (Phone?.Length < 10 || Phone?.Length > 20)
                throw new ArgumentOutOfRangeException("Invalid phone number length");
            foreach (var numberch in numbers)
            {
                if (!Phone.StartsWith(numberch))
                    throw new ArgumentOutOfRangeException("Invalid phone number");

            }
        } 
    }
    public bool? HasInsurance { get; set; }
    public Patient(string Name, string Surname, short Age, string Workaddress, string BloodGroup,string Phone) : base(Name, Surname, Age, Workaddress)
    {
        this.BloodGroup = BloodGroup;
        this.Phone = Phone;
        if(Workaddress != "None")
            HasInsurance = true;
        else 
            HasInsurance = false;

        bloodgroups.Add("1-");
        bloodgroups.Add("1+");
        bloodgroups.Add("2-");
        bloodgroups.Add("2+");
        bloodgroups.Add("3-");
        bloodgroups.Add("3+");
        bloodgroups.Add("4-");
        bloodgroups.Add("4+");
        numbers.Add("050");
        numbers.Add("051");
        numbers.Add("055");
        numbers.Add("060");
        numbers.Add("070");
        numbers.Add("077");
    }

    public override string ToString()
    {
        return @$"{base.ToString()}
Phone: {Phone}
Bloog : {BloodGroup}
Insurance: {HasInsurance}";
}

}
    
    

