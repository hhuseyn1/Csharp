namespace CEO;
using Main;
using Employee;

class CEO : Employee, IControl, IMakeMeeting, IDecreasePersentage, IOrganizer
{
    public CEO(string name, string surname, int age, double salary, string position) : base(name, surname, age, salary, position) { }

    public void Control() => Console.WriteLine("CEO Controling");

    public void Organize() => Console.WriteLine("CEO Organizing");

    public void MakeMeeting() => Console.WriteLine("CEO MakeMeeting");
    public void DecreasePersentage() => Console.WriteLine("CEO DecreasePersentaging");


    public override string ToString()=>base.ToString();
    
}
 





