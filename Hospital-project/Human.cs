namespace Human;
class Human {
	public string? name;
	public string? surname;
public string? Name { get { return name; } set {
			if (Name?.Length <= 2)
				throw new ArgumentException("Invalid name");
			name = value;
		} }
public string? Surname { get { return surname; } set {
			if (Surname?.Length <= 2)
				throw new ArgumentException("Invalid surname");
			surname = value;
		} }
public short age;
public short Age { get {
			return age; 
		}
		set {
			if (Age < 0 || Age > 200)
				throw new ArgumentOutOfRangeException("Invalid age");
			age=value;
		}

	}
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
   

