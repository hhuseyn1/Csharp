namespace Main;
#region Usings
using Doctor;
using Hospital;
using System;
using Patient;
using System.Collections.Generic;
using JsonSerializer = System.Text.Json.JsonSerializer;
using System.Xml.Serialization;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
#endregion
#nullable disable
class Program
{
    static void ChooseMenu(int value)
    {
        if (value == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1]Pediatr");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[2]Travmatolog");
            Console.WriteLine("[3]Stamatolog");
        }

        else if (value == 2)
        {
            Console.WriteLine("[1]Pediatr");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[2]Travmatolog");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[3]Stamatolog");

        }

        else if (value == 3)
        {
            Console.WriteLine("[1]Pediatr");
            Console.WriteLine("[2]Travmatolog");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[3]Stamatolog");
            Console.ForegroundColor = ConsoleColor.White;
        }

    }

    static void HaveWA(int value)
    {
        if (value == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1]Yes");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[2]No");
        }

        else if (value == 2)
        {
            Console.WriteLine("[1]Yes");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[2]No");
            Console.ForegroundColor = ConsoleColor.White;
        }



    }

    static bool StartsWithAny(string source, List<string> strings)
    {
        string startsWithValue = null;

        foreach (var valueToCheck in strings)
        {
            if (source.StartsWith(valueToCheck))
            {
                startsWithValue = valueToCheck;
                return true;
            }
        }

        return false;
    }

    static void ChooseFType(int value)
    {
        if (value == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[1]Xml");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[2]Json");
        }

        else if (value == 2)
        {
            Console.WriteLine("[1]Xml");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[2]Json");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    static void Main()
    {
        #region numbers
        List<string> numbers = new List<string>();
        numbers.Add("050");
        numbers.Add("051");
        numbers.Add("055");
        numbers.Add("060");
        numbers.Add("070");
        numbers.Add("077");
        #endregion
        #region bloodgroups
        List<string> bloodgroups = new List<string>();
        bloodgroups.Add("1-");
        bloodgroups.Add("1+");
        bloodgroups.Add("2-");
        bloodgroups.Add("2+");
        bloodgroups.Add("3-");
        bloodgroups.Add("3+");
        bloodgroups.Add("4-");
        bloodgroups.Add("4+");
        #endregion
        #region variables
        int choiceNumber = 1;
        string phone, name, surname, bloodgroup, workadress = null;
        short age = default;
        int waNumber = 1;
        bool isRunning = true;
        bool isRunning2 = true;
        double price = default;
        #endregion
        #region doctors
        Doctor[] doctors =
        {
            new Doctor("Pediatr1","P/Surname1",25,"Jalil Mammadquluzade 73",1,"Pediatr",4),
            new Doctor("Pediatr2","P/Surname2",47,"Jalil Mammadquluzade 73",2,"Pediatr",23),
            new Doctor("Pediatr3","P/Surname3",32,"Jalil Mammadquluzade 73",3,"Pediatr",8),
            new Doctor("Travmatoloq1","T/Surname1",26,"Jalil Mammadquluzade 73",4,"Travmatoloq",5),
            new Doctor("Travmatoloq2","T/Surname2",42,"Jalil Mammadquluzade 73",5,"Travmatoloq",17),
            new Doctor("Travmatoloq3","T/Surname3",31,"Jalil Mammadquluzade 73",6,"Travmatoloq",6),
             new Doctor("Stamatoloq1","S/Surname1",28,"Jalil Mammadquluzade 73",7,"Stamatoloq",5),
            new Doctor("Stamatoloq2","S/Surname2",24,"Jalil Mammadquluzade 73",8,"Stamatoloq",1),
            new Doctor("Stamatoloq3","S/Surname3",31,"Jalil Mammadquluzade 73",9,"Stamatoloq",7)
        };


        List<Doctor> doctorsForFile = new List<Doctor>()
        {
            new Doctor("Pediatr1","P/Surname1",25,"Jalil Mammadquluzade 73",1,"Pediatr",4),
            new Doctor("Pediatr2","P/Surname2",47,"Jalil Mammadquluzade 73",2,"Pediatr",23),
            new Doctor("Pediatr3","P/Surname3",32,"Jalil Mammadquluzade 73",3,"Pediatr",8),
            new Doctor("Travmatoloq1","T/Surname1",26,"Jalil Mammadquluzade 73",4,"Travmatoloq",5),
            new Doctor("Travmatoloq2","T/Surname2",42,"Jalil Mammadquluzade 73",5,"Travmatoloq",17),
            new Doctor("Travmatoloq3","T/Surname3",31,"Jalil Mammadquluzade 73",6,"Travmatoloq",6),
             new Doctor("Stamatoloq1","S/Surname1",28,"Jalil Mammadquluzade 73",7,"Stamatoloq",5),
            new Doctor("Stamatoloq2","S/Surname2",24,"Jalil Mammadquluzade 73",8,"Stamatoloq",1),
            new Doctor("Stamatoloq3","S/Surname3",31,"Jalil Mammadquluzade 73",9,"Stamatoloq",7)

        };



        Doctor[] Pediatrs = {
               new Doctor("Pediatr1","P/Surname1",25,"Jalil Mammadquluzade 73",1,"Pediatr",4),
               new Doctor("Pediatr2","P/Surname2",47,"Jalil Mammadquluzade 73",2,"Pediatr",23),
               new Doctor("Pediatr3","P/Surname3",32,"Jalil Mammadquluzade 73",3,"Pediatr",8)
           };
        Doctor[] Travmatologs =
        {
               new Doctor("Travmatoloq1","T/Surname1",26,"Jalil Mammadquluzade 73",4,"Travmatoloq",5),
               new Doctor("Travmatoloq2","T/Surname2",42,"Jalil Mammadquluzade 73",5,"Travmatoloq",17),
               new Doctor("Travmatoloq3","T/Surname3",31,"Jalil Mammadquluzade 73",6,"Travmatoloq",6)
           };
        Doctor[] Stamtologs =
        {
               new Doctor("Stamatoloq1","S/Surname1",28,"Jalil Mammadquluzade 73",7,"Stamatoloq",5),
               new Doctor("Stamatoloq2","S/Surname2",24,"Jalil Mammadquluzade 73",8,"Stamatoloq",1),
               new Doctor("Stamatoloq3","S/Surname3",31,"Jalil Mammadquluzade 73",9,"Stamatoloq",7)
           };
        #endregion


        Hospital hospital = new Hospital("StepIt Hospital", "000 000 00 00");



        Console.WriteLine("Welcome");
        Thread.Sleep(1000);
        Console.WriteLine("             My");
        Thread.Sleep(1000);
        Console.WriteLine("                     Hospital");
        Thread.Sleep(1000);
        Console.WriteLine("                                   !!!!!");
        Thread.Sleep(1000);
        Console.Clear();
        Console.WriteLine("We must get some information about you");
        Thread.Sleep(1500);
        Console.Clear();
        Console.WriteLine("Enter name: ");
        name = Console.ReadLine();
        #region NameCheck
        if (name.Length <= 2)
            throw new ArgumentOutOfRangeException("Invalid name");
        #endregion
        Console.WriteLine("Enter surname: ");
        surname = Console.ReadLine();
        #region SurnameCheck
        if (surname.Length <= 2)
            throw new ArgumentOutOfRangeException("Invalid surname");
        #endregion
        Console.WriteLine("Enter age: ");
        age = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Enter phone: ");
        phone = Console.ReadLine();
        #region PhoneCheck
        string[] checkPhone = phone.Split(' ');
        if (phone?.Length < 9 || phone?.Length > 20)
            throw new ArgumentOutOfRangeException("Invalid phone number length");

        if (!StartsWithAny(phone, numbers))
            throw new ArgumentOutOfRangeException("Invalid phone number");
        if (phone.Contains(' '))
        {
            if (checkPhone.ElementAt(1)[0].ToString() == "0")
                throw new ArgumentException("Invalid phone number");
        }
        else
        {
            if (phone[3].ToString() == "0")
                throw new ArgumentException("Invalid phone number");
        }
        #endregion
        Console.WriteLine("Enter bloodgroup: ");
        bloodgroup = Console.ReadLine();
        #region BloodCheck


        foreach (var bgcheck in bloodgroups)
        {
            if (bloodgroups.Contains(bgcheck))
                break;
            else
                throw new ArgumentOutOfRangeException("Invalid blood group");
        }


        Thread.Sleep(2000);
        #endregion
        Console.Clear();

        while (true)
        {
            Console.WriteLine("Did you have Work address?");
            HaveWA(waNumber);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (waNumber == 1)
                        waNumber = 2;
                    else waNumber--;
                    break;
                case ConsoleKey.DownArrow:
                    if (waNumber == 2)
                        waNumber = 1;
                    else waNumber++;
                    break;
                case ConsoleKey.Enter:
                    if (waNumber == 1)
                    {
                        Console.WriteLine("Enter work address:");
                        workadress = Console.ReadLine();
                    }
                    else if (waNumber == 2)
                    {
                        workadress = "None";
                    }
                    isRunning = false;
                    break;

                default:
                    break;

            }
            Console.Clear();
            break;
        }

        Patient patient = new(name, surname, age, workadress, bloodgroup, phone);

        while (isRunning)
        {
            ChooseMenu(choiceNumber);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (choiceNumber == 1)
                        choiceNumber = 3;
                    else choiceNumber--;
                    break;
                case ConsoleKey.DownArrow:
                    if (choiceNumber == 3)
                        choiceNumber = 1;
                    else choiceNumber++;
                    break;
                case ConsoleKey.Enter:
                    {
                        Console.Clear();
                        if (choiceNumber == 1)
                        {
                            foreach (var doctor in Pediatrs)
                            {
                                Console.WriteLine(doctor);
                            }

                        }
                        else if (choiceNumber == 2)
                        {
                            foreach (var doctor in Travmatologs)
                            {
                                Console.WriteLine(doctor);
                            }

                        }
                        else if (choiceNumber == 3)
                        {
                            foreach (var doctor in Stamtologs)
                            {
                                Console.WriteLine(doctor);
                            }
                        }
                        Console.WriteLine("Enter doctor id: ");
                        int chooseDoc = Convert.ToInt32(Console.ReadLine());
                        if (choiceNumber == 1 && (chooseDoc < 1 || chooseDoc > 3))
                            throw new ArgumentOutOfRangeException("Invalid Doctor id");
                        else if (choiceNumber == 2 && (chooseDoc < 4 || chooseDoc > 6))
                            throw new ArgumentOutOfRangeException("Invalid Doctor id");
                        else if (choiceNumber == 3 && (chooseDoc < 7 || chooseDoc > 9))
                            throw new ArgumentOutOfRangeException("Invalid Doctor id");

                        short day, year, month, hour, minute, second = 00;
                        Console.Clear();
                        Console.WriteLine("Enter admition date");
                        Console.WriteLine("Year: ");
                        year = Convert.ToInt16(Console.ReadLine());
                        if (year < DateTime.Now.Year || year > (DateTime.Now.Year) + 1)
                            throw new ArgumentOutOfRangeException("Invalid wait time");
                        Console.WriteLine("Month: ");
                        month = Convert.ToInt16(Console.ReadLine());
                        if (year == ((DateTime.Now.Year) + 1))
                        {
                            if (month < 1 || month > 12)
                                throw new ArgumentOutOfRangeException("Invalid wait time");
                        }
                        else if (year == DateTime.Now.Year)
                        {
                            if (month < DateTime.Now.Month || month > 12)
                                throw new ArgumentOutOfRangeException("Invalid wait time");
                        }
                        Console.WriteLine("Day: ");
                        day = Convert.ToInt16(Console.ReadLine());
                        if (year == DateTime.Now.Year && month == DateTime.Now.Month)
                        {
                            if (day < DateTime.Now.Day || day > 31)
                                throw new ArgumentOutOfRangeException("Invalid wait time");
                        }
                        if (day < 1 || day > 31)
                            throw new ArgumentOutOfRangeException("Invalid wait time");
                        Console.WriteLine("Hour: ");
                        hour = Convert.ToInt16(Console.ReadLine());
                        if (hour < 8 || hour > 18)
                            throw new ArgumentOutOfRangeException("Invalid wait time");
                        Console.WriteLine("Minute: ");
                        minute = Convert.ToInt16(Console.ReadLine());
                        if (minute < 0 || minute > 59)
                            throw new ArgumentOutOfRangeException("Invalid wait time");

                        isRunning = false;
                    }
                    break;


                default:
                    break;

            }
            Console.Clear();
        }

        int Ftype = 1;
        Console.WriteLine("Enter file type: ");
        while (true)
        {
            ChooseFType(Ftype);
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (Ftype == 1)
                        Ftype = 2;
                    else Ftype--;
                    break;
                case ConsoleKey.DownArrow:
                    if (Ftype == 2)
                        Ftype = 1;
                    else Ftype++;
                    break;
                case ConsoleKey.Enter:
                    if (Ftype == 1)
                    {
                        using var writer = new XmlTextWriter("doctors.xml", Encoding.Default);
                        writer.Formatting = System.Xml.Formatting.Indented;


                        writer.WriteStartDocument();
                        writer.WriteStartElement("doctors");

                        foreach (Doctor doctor in doctors)
                        {
                            writer.WriteStartElement("doctor");


                            writer.WriteAttributeString(nameof(doctor.Id),doctor.Id.ToString());
                            writer.WriteAttributeString(nameof(doctor.Name),doctor.Name);
                            writer.WriteAttributeString(nameof(doctor.Surname),doctor.Surname);
                            writer.WriteAttributeString(nameof(doctor.Workaddress),doctor.Workaddress);
                            writer.WriteAttributeString(nameof(doctor.ExperienceYear),doctor.Id.ToString());
                            writer.WriteAttributeString(nameof(doctor.Position),doctor.Position);
                      

                            writer.WriteEndElement();
                        }


                        writer.WriteEndElement();
                        writer.WriteEndDocument();



                        #region ReadXml
                        //XmlDocument doc = new XmlDocument();
                        //
                        //doc.Load("doctors.xml");
                        //
                        //var root = doc.DocumentElement;
                        //
                        //if (root.HasChildNodes)
                        //{
                        //    foreach (XmlNode node in root.ChildNodes)
                        //    {
                        //        var doctor = new Doctor
                        //        {
                        //            Id = int.Parse(node.Attributes[0].Value),   
                        //            Name = node.Attributes[1].Value,   
                        //            Surname = node.Attributes[2].Value,   
                        //            Workaddress = node.Attributes[3].Value,   
                        //            ExperienceYear= int.Parse(node.Attributes[4].Value),   
                        //            Position= node.Attributes[5].Value   
                        //        };
                        //
                        //        Console.WriteLine(doctor);
                        //    }
                        //}
                        //



                        #endregion

                        var xml = new XmlSerializer(typeof(Doctor));
                        using var fs = new FileStream("doctors.xml", FileMode.Create);
                        xml.Serialize(fs, doctors);

                        #region DeSerializeXml
                        //Doctor doctor= null;
                        //
                        //var Dxml = new XmlSerializer(typeof(Doctor));
                        //using var Dfs = new FileStream("TranslatorArmy.xml", FileMode.Open);
                        //doctor = Dxml.Deserialize(Dfs) as Doctor;
                        //
                        //Console.WriteLine("Deserialized");
                        //Console.WriteLine(doctor);
                        #endregion

                    }
                    else if (Ftype == 2)
                    {
                        var writeString = JsonSerializer.Serialize(doctors);
                        File.WriteAllText("doctors.json", writeString);

                        #region DeserializeJson
                        //Doctor[] doctor = null;
                        //var stringData = File.ReadAllText("doctors.json");
                        //doctor = JsonConvert.DeserializeObject<Doctor[]>(stringData);
                        #endregion
                    }
                    break;

            }
            Console.Clear();
        }

    }

}