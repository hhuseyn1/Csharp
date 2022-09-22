namespace Human;
class Human {

public string? Name { get; set; }
public string? Surname { get; set; }
public short Age { get; set; }
public string? Workaddress { get; set; }

	public Human(string Name,string Surname,short Age,string Workaddress){
	this.Name = Name;
	this.Surname = Surname;
	this.Age = Age;	
	this.Workaddress=Workaddress;
	}

	public override string ToString()
	{
return $@"---- Info ----
Name: {Name}
Surname: {Surname}
Age: {Age}
Workaddress: {Workaddress}
";}




}
   

