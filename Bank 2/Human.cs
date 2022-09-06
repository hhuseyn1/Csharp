namespace Human;

class Human
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public Human(string name, string surname, int age, double salary)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Salary = salary;
        
    }
}

