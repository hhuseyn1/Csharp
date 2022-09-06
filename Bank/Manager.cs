namespace Manager;
using Employee;
using Main;

class Manager : Employee, IOrganizer, ICalculateSalaries
{
   
    public Manager(string name, string surname, int age, double salary, string position) : base(name, surname, age, salary, position) { }
    
    public void CalculateSalaries() => Console.WriteLine("Manager CalculateSalaries");
    
    public void Organize() => Console.WriteLine("Manager Organize");

    public override string ToString() => $@"{base.ToString()}";
}

