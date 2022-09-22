namespace Hospital;
using Patient;
using Doctor;

class Hospital
{
    public string? Location { get; set; }
    public string? Phone { get; set; }
    public Hospital(string Location, string Phone)
    {
        this.Location = Location;
        this.Phone = Phone;

    }
    public override string ToString()
    {
        return @$"---- Hospital ----
Location: {Location}
Phone: {Phone}
";}


}