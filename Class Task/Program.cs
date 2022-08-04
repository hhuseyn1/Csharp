namespace PointFractionCounter;

class Counter
{
    private int max;
    private int min;
    private int cValue;

   
    public Counter()
    {
        min = 0;
        max = 100;
        cValue = min;
    }


    public Counter(int min, int max)
    {
        this.min = min;
        this.max = max;
        cValue = min;
    }

    public int Max { get; set; }
   public int Min { get; set; }
   public int CValue { get; set; }



    public int Increment() { return min++; }
    public int Decrement() { return max--; }
    public int getCValue() { return cValue; }

    public override string ToString()
    {
        return $"Minimum value is {min}\nMaximum value is {max}";
    }
}


class Point
    {
        private int x;
        private int y;

        public Point()
        {
            x=0; 
            y=0;
        }
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Showdata() { return $"X is {x}\nY is {y}"; }
        public int Increment() { return x++ & y++; }
        public int Decrement() { return x-- & y--; }
    }

class Fraction
{
    protected int numerator;
    protected int denominator;

    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }
    public Fraction(int numerator,int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }
  
 public int Numerator { get; set; }
 public int Denominator { get; set; }

    public void Addition(Fraction f)
    {
       
        if (f.denominator == denominator)
            numerator +=f.numerator;

        else
        {
            numerator = (f.numerator * denominator) + (numerator * f.denominator);
            denominator *= f.denominator;
        }
        
    }

    public void Substraction(Fraction f)
    {
        if (f.denominator == denominator)
        {
            if (numerator > f.numerator)
                numerator -= f.numerator;
            else
                numerator = f.numerator - numerator;
        }

        else
        {
            if (numerator > f.numerator)
                numerator = (numerator * f.denominator) - (f.numerator * denominator);
               else
                numerator = (f.numerator * denominator) - (numerator * f.denominator);
        }
        
    }
    public void Multiplication(Fraction f)
    {
        numerator *= f.numerator;
        denominator *=  f.denominator;
    }
    public void Division(Fraction f)
    {
        numerator *= f.denominator;
        denominator *= f.numerator;
    }
    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }
}


class Program
{
   
    static void Main()
    {

        Counter counter = new Counter(0,100);
        Console.WriteLine(counter);

        Console.WriteLine(counter.getCValue());



        //Point point=new Point(1,2);
        //Console.WriteLine(point.Showdata());
        //point.Increment();
        //Console.WriteLine();
        //Console.WriteLine(point.Showdata());
        //point.Decrement();
        //Console.WriteLine();
        //Console.WriteLine(point.Showdata());





        //Fraction fraction1 = new(1, 3);
        //Fraction fraction2 = new (2, 3);
        //fraction1.Addition(fraction2);
        //Console.WriteLine(fraction1.ToString());


    }
}