namespace Indexer;


class Indexer
{
    public string[,] Quiz { get; set; }
    public string[][] World { get; set; }

    public Indexer()
    {
        Quiz = new string[2, 4];
        World = new string[2][];
    }


    public string this[int index1, int index2]
    {
        get => Quiz[index1, index2];
        set => Quiz[index1, index2] = value;
    }

    public string[] this[int index]
    {
        get => World[index];
        set => World[index] = value;
    }

}

class Program
{
    static void Main()
    {
        Indexer task = new();


        // task[0, 0] = "Question1";
        // task[0, 1] = "Answer1.1";
        // task[0, 2] = "Answer1.2";
        // task[0, 3] = "Answer1.3";
        // 
        // task[1, 0] = "Question2";
        // task[1, 1] = "Answer2.1";
        // task[1, 2] = "Answer2.2";
        // task[1, 3] = "Answer2.3";

        // Console.WriteLine(task[0, 0]);


        task[0] = new string[3];
        task[1] = new string[4];



        task[0][0] = "Azerbaijan";
        task[0][1] = "Baku";


        Console.WriteLine(task[0][0]);
        Console.WriteLine(task[0][1]);
    }
}