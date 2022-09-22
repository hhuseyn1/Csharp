namespace Main;
using Doctor;
using Patient;
using Human;
using Hospital;
#nullable disable
class Program
{


    static void Main()
    {
        
        Doctor[] Pediatrs = {
            new Doctor(1,"Pediatr1","P/Surname1",25,"Jalil Mammadquluzade 73","Pediatr",4),
            new Doctor(2,"Pediatr2","P/Surname2",47,"Jalil Mammadquluzade 73","Pediatr",23),
            new Doctor(3,"Pediatr3","P/Surname3",32,"Jalil Mammadquluzade 73","Pediatr",8)
        };
        Doctor[] Travmatologs =
        {
            new Doctor(4,"Travmatoloq1","T/Surname1",26,"Jalil Mammadquluzade 73","Travmatoloq",5),
            new Doctor(5,"Travmatoloq2","T/Surname2",42,"Jalil Mammadquluzade 73","Travmatoloq",17),
            new Doctor(6,"Travmatoloq3","T/Surname3",31,"Jalil Mammadquluzade 73","Travmatoloq",6)
        };
        Doctor[] Stamtologs =
        {
            new Doctor(7,"Stamatoloq1","S/Surname1",28,"Jalil Mammadquluzade 73","Stamatoloq",5),
            new Doctor(8,"Stamatoloq2","S/Surname2",24,"Jalil Mammadquluzade 73","Stamatoloq",1),
            new Doctor(9,"Stamatoloq3","S/Surname3",31,"Jalil Mammadquluzade 73","Stamatoloq",7)
        };
       

        Hospital hospital = new Hospital("StepIt Hospital","000 000 00 00");

        string phone, name, surname, email, workadress;
        short age=default,bloodgroup=default;
        while (true)
        {
            Console.WriteLine("Enter name: ");
            name= Console.ReadLine();
            Console.WriteLine("Enter surname: ");
            surname= Console.ReadLine();
            Console.WriteLine("Enter phone: ");
            phone= Console.ReadLine();
            Console.WriteLine("Enter email: ");
            email= Console.ReadLine();
            Console.WriteLine("Enter age: ");
            age= Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter workadress: ");
            workadress= Console.ReadLine();
            Console.WriteLine("Enter bloodgroup: ");
            bloodgroup= Convert.ToInt16(Console.ReadLine());


            Patient patient = new(name,surname,age,workadress,bloodgroup,phone);

            Console.Clear();
            Console.WriteLine(@"What would you need?");
            Console.WriteLine(@"[1]Pediatr
[2]Travmatoloq
[3]Stamatoloq");
            int doctorChoice = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            Console.WriteLine("Enter doctor id: ");
            switch (doctorChoice)
            {
                case 1:
                    {
                        for (int i = 0; i < Pediatrs.Length; i++)
                        {
                            for (int j = 0; j < Pediatrs.Length; j++)
                            {
                                Console.WriteLine(Pediatrs[j]);
                                Console.WriteLine(Pediatrs[j].AdmitionHours[j]);
                            }
                            int chooseDoctor = Convert.ToInt32(Console.ReadLine());
                            if (chooseDoctor == 1)
                                Pediatrs[i].AdmitionHours.RemoveAt(1);
                            else if (chooseDoctor == 2)
                                Pediatrs[i].AdmitionHours.RemoveAt(2);
                            else if (chooseDoctor == 3)
                                Pediatrs[i].AdmitionHours.RemoveAt(3);
                            Console.Clear();
                            Console.WriteLine($"Thank you {name} {surname} you admit the doctor {Pediatrs[chooseDoctor-1].Name} ");
                            break;
                        }
                    }
                    break;
                case 2:
                    {
                        for (int i = 0; i < Travmatologs.Length; i++)
                        {
                            for (int j = 0; j < Travmatologs.Length; j++)
                            {
                                Console.WriteLine(Travmatologs[j]);
                                Console.WriteLine(Travmatologs[j].AdmitionHours[j]);
                            }
                            int chooseDoctor = Convert.ToInt32(Console.ReadLine());
                            if (chooseDoctor == 4)
                                Travmatologs[i].AdmitionHours.RemoveAt(1);
                            else if (chooseDoctor == 5)
                                Travmatologs[i].AdmitionHours.RemoveAt(2);
                            else if (chooseDoctor == 6)
                                Travmatologs[i].AdmitionHours.RemoveAt(3);
                            Console.Clear();
                            Console.WriteLine($"Thank you {name} {surname} you admit the doctor {Travmatologs[i].Name} ");
                            break;
                        }

                    }
                    break;

                case 3:
                    {

                        for (int i = 0; i < Stamtologs.Length; i++)
                        {
                            for (int j = 0; j < Stamtologs.Length; j++)
                            {
                                Console.WriteLine(Stamtologs[j]);
                                Console.WriteLine(Stamtologs[j].AdmitionHours[j]);
                            } 
                            int chooseDoctor = Convert.ToInt32(Console.ReadLine());
                            if(chooseDoctor==7)
                            Stamtologs[i].AdmitionHours.RemoveAt(1);
                            else if(chooseDoctor==8)
                            Stamtologs[i].AdmitionHours.RemoveAt(2);
                            else if(chooseDoctor==9)
                            Stamtologs[i].AdmitionHours.RemoveAt(3);
                            Console.Clear();
                            Console.WriteLine($"Thank you {name} {surname} you admit the doctor {Stamtologs[i].Name} ");
                            break;
                        }

                    }
                    break;
                default:
                    break;
            }
            Thread.Sleep(2000);
            Console.Clear();
        }
        


    }



}