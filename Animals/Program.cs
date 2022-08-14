namespace Animals;
enum Gender { NoSelected,Male,Female}
class Animal
{
    public int sleepCounter = 0;
    public string? Name { get; set; }
    public Gender Gender { get; set; }
    public int Energy { get; set; }
    public float Price { get; set; }
    public int Age { get; set; }
    public int MealQuantity { get; set; }
    public Animal()
    {
        Name = default;
        Energy = default;
        Gender = Gender.NoSelected;
        Price = 50;
        Age = default;
        MealQuantity = default;
    }

    public Animal(string name, Gender gender, int energy, float price, int age, int mealQuantity)
    {
        Name = name;
        Gender = gender;
        Energy = energy;
        Price = price;
        Age = age;
        MealQuantity = mealQuantity;
    }

    public virtual void Eat() { }

    public virtual void Sleep() { }

    public virtual void Play() { }

    public override string ToString()
    {
        return $@"
Name: {Name}
Age: {Age}            
Gender -> {Gender}
Meal Quantity: 100/{MealQuantity}
Energy: 100/{Energy}
Price: {Price}
";
    }
}

    class Dog :  Animal
 {
        public Dog(string name, Gender gender, int energy, float price, int age, int mealQuantity) : base(name, gender, energy, price, age, mealQuantity) { }
        public override void Eat()
        {
            if (Energy <= 90)
            {
                Energy += 10;
                MealQuantity += 20;
                Price += 2.50f;
            Console.WriteLine("Dog ate food...");
            }
            else
                Console.WriteLine("Dog is repleted");
        }

        public override void Sleep()
        {

            if (Energy <= 30 && MealQuantity >= 20)
            {
                Energy = 100;
                sleepCounter++;
                if (sleepCounter >= 4)
                {
                    sleepCounter = 0;
                    Age += 1;
                }
            }
            else if (Energy >= 30)
            {
                Console.WriteLine("Dog is not sleepy");
            }

            else
            {
                Console.WriteLine("Dog is hungry");
            }

        }

        public override void Play()
        {

            if (Energy <= 30 && Gender == Gender.Male)
            {
                Console.WriteLine("Dog can not play he is so sleepy");
            }
            else if (Energy <= 30 && Gender == Gender.Female)
            {
                Console.WriteLine("Dog can not play she is so sleepy");
            }
            else
            {
                Energy -= 35;
                MealQuantity -= 20;
                Console.WriteLine("Dog is playing...");
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }

    }

    class Cat : Animal
    {
        public Cat(string name, Gender gender, int energy, float price, int age, int mealQuantity) : base(name, gender, energy, price, age, mealQuantity) { }
        public override void Eat()
        {
            Console.WriteLine("Cat ate food...");
            if (Energy <= 95)
            {
                Energy += 5;
                MealQuantity += 10;
                Price += 1.00f;
            }
            else
                Console.WriteLine("Cat is repleted");
        }

        public override void Sleep()
        {

            if (Energy <= 20 && MealQuantity >= 10)
            {
                Energy = 100;
                sleepCounter++;
                if (sleepCounter >= 4)
                {
                    sleepCounter = 0;
                    Age += 1;
                }
            }
            else if (Energy >= 20)
            {
                Console.WriteLine("Cat is not sleepy");
            }

            else
            {
                Console.WriteLine("Cat is hungry");
            }

        }
        public override void Play()
        {

            if (Energy <= 20 && Gender == Gender.Male)
            {
                Console.WriteLine("Cat can not play he is so sleepy");
            }
            else if (Energy <= 20 && Gender == Gender.Female)
            {
                Console.WriteLine("Cat can not play she is so sleepy");
            }
            else
            {
                Energy -= 20;
                MealQuantity -= 15;
                Console.WriteLine("Cat is playing...");
            }
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }


class Petshop
{
    public string? Name { get; set; }
    public Animal[]? animals;
    public Petshop()
    {
        Name = "PETshop";
    }
    public Petshop(string? name)
    {
        Name = name;
    }

    public Animal[] RemoveByNickname(Animal[] animals, string? nickname)
    {
        Animal[] temp = new Animal[animals.Length-1];
        int j = 0;
        for (int i = 0; i < animals.Length; i++)
        {
            if (nickname == animals[i].Name)
                continue;
            else
                temp[j++] = animals[i];
        }
        return temp;
    }

    class Program
    {
        static void Main()
        {
            Animal[] animals = {
                new Dog("Dog 1", Gender.Male, 90, 900, 1, 90),
                new Dog("Dog 2", Gender.Female, 80, 80, 2, 60),
                new Dog("Cat 1", Gender.Male, 70, 60, 1, 40),
                new Cat("Cat 2", Gender.Female, 60, 30, 1, 80)
            };

            Petshop petshop = new();
            foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            petshop.RemoveByNickname(animals, "Dog 1");
            
            }foreach (var animal in animals)
            {
                Console.WriteLine(animal.Name);
            }  

        }
    }
}





