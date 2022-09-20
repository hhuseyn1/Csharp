namespace BackUp;
using Flash;
using HDD;
using DVD;
class Program
{
    static void Main()
    {
        Flash flash = new Flash("Flash","ModelFlash1",256,128);
        DVD dvd= new DVD("DVD","ModelDVD1",512,256,1);
        HDD hdd = new HDD("HDD","ModelHDD1",128,32);

        while (true)
        {
            Console.WriteLine(@"[1]Flash
[2]HDD
[3]DVD");
        int choice=Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(flash.ToString());

            }

            else if (choice == 2)
            {

                Console.WriteLine(dvd.ToString());

            }

            else if (choice == 3)
            {

                Console.WriteLine(hdd.ToString());

            }
            else
            {
                Console.WriteLine("Wrong input !!!");
                break;

            }

        }

    

    }
}