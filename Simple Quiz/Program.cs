using System;
using System.Collections.Generic;



namespace Simple_Quiz
{

    class Program
    {

        static void Main()
        {
            Random random = new Random();
            int num = 0;
            int score = 0;

            string answer;
            string[][] questions = new string[10][];
            questions[0] = new string[] { "When computer was first invented?", "1820", "1823", "1834", "A" };
            questions[1] = new string[] { "Which day is celebrated as 'World Computer Literacy day'?", "October 6", "December 2", "October 4", "B" };
            questions[2] = new string[] { "Who is known as human computer of India?", "Sundar Pichai", "Sathya Nathella", "Shakunthala Devi", "C" };
            questions[3] = new string[] { "Do no evil' is the tag line ofDo no evil' is the tag line of", "Adobe", "Microsoft", "Google", "D" };
            questions[4] = new string[] { "Extension of PDF", "Portable Document Format", "Personal Document Format", "Presentation Document Format", "A" };
            questions[5] = new string[] { "Which company invented floppy disk?", "Microsoft", "Intel", "IBM", "A" };
            questions[6] = new string[] { "IC chips are usually made of", "Silicon", "Chromium", "Gold", "B" };
            questions[7] = new string[] { "Technology no longer protected by copyrights and available to all is", "Proprietary", "Experimental", "Free", "A" };
            questions[8] = new string[] { "In binary language each alphabet is made up of unique combinationof", "8 bytes", "8 character", "8 bits", "D" };
            questions[9] = new string[] { "The term bit is short for", "Byte", "Binary digit", "Binary number", "C" };
            for (int i = 0; i < questions.Length; i++)
            {

                Console.WriteLine($"{++num}){questions[i][0]}");
                Console.WriteLine($"A.{questions[i][1]}");
                Console.WriteLine($"B.{questions[i][2]}");
                Console.WriteLine($"C.{questions[i][3]}");
            
            answer = Convert.ToString(Console.ReadLine());
            if (answer.ToUpper() == questions[i][4])
            {
                    score += 10;
            }
            else
            {
                if (score >= 10)
                    score -= 10;
                else
                    continue;
            }
        

        }
        
        Console.WriteLine($"Thank you for playing game your score -> {score}");
        }










    }
    }
