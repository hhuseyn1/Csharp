using System;

namespace Calculator
{
    class Program
    {
        static float Addition(float a,float b)
        {
            return a + b;
        }

        static float Multiplication(float a, float b)
        {
            return a * b;
        }
        static float Subtraction(float a, float b)
        {
            return a - b;
        }
        static float Division(float a, float b)
        {
            return a / b;
        }


        static void Main()
        {
            
               Console.WriteLine("Enter first number: ");
                float a1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                float b1 =float.Parse(Console.ReadLine());
                Console.WriteLine("Operation: ");
                char op = Convert.ToChar(Console.Read());
                float result = op switch
                {
                    '+' => Addition(a1, b1),
                    '-' => Subtraction(a1, b1),
                    '*' => Multiplication(a1, b1),
                    '/' => Division(a1, b1),
                    _ =>0
                };

            Console.WriteLine($"Result: {result}");
            }
       
    }

}

