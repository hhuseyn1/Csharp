namespace Userspace;

class User
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Email { get; set; }
    
    public string? Name {get;set;}
    public string? Surname { get; set; }
    public string? Password { get; set; }
    
    public short Age{ get; set; }

    public User(string Email,string Name,string Surname ,string Password,short Age)
    {
        this.Email = Email;
        this.Name = Name;
        this.Surname = Surname;
        this.Password = Password;
        this.Age = Age;

    }


    public override string ToString()
    {
        return $@"Name: {Name}
Surname: {Surname}
Age: {Age}";
}



}


