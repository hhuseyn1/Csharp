namespace Employee;
using Human;
 class Employee:Human
{

    public string? Position{ get; set; }
    public Employee(string name, string surname, int age, double salary, string position): base(name,  surname,  age,  salary)
    {
        Position = position;
    }

    public override string ToString(){
return $@"{base.ToString()}
Position: {Position}";
}
}



