using System;
using System.Diagnostics;

namespace IndexerTask;

class DictionarywIndexer
{
    public string[,] Dictionary { get; set; }
    public DictionarywIndexer()
    {
        Dictionary = new string[16, 2];
    }

    public string this[int index1, int index2]
    {
        get => Dictionary[index1, ++index2];
        set => Dictionary[index1, index2] = value;
    }

       
}

struct Article
{
    public string? ProductName { get; set; }
    public Guid ProductCode { get; set; }
    public double Price { get; set; }
    public Article(string ProductName, Guid ProductCode, double Price) : this()
    {
        this.ProductName = ProductName;
        this.ProductCode = ProductCode;
        this.Price = Price;
    }


    public static double operator +(Article a1, Article a2)
    {
        return a1.Price + a2.Price;
    }
    public static double operator -(Article a1, Article a2)
    {
        return a1.Price - a2.Price;
    }
    public static double operator *(Article a1, Article a2)
    {
        return a1.Price * a2.Price;
    }
    public static double operator /(Article a1, Article a2)
    {
        return a1.Price * a2.Price;
    }
    public static Article operator ++(Article a1)
    {
        a1.Price++;
        return a1;
    }
    public static Article operator --(Article a1)
    {
        a1.Price--;
        return a1;
    }


    public static bool operator ==(Article a1, Article a2) => (a1.ProductCode == a2.ProductCode);
    public static bool operator !=(Article a1, Article a2) => !(a1.ProductCode == a2.ProductCode);

    public static bool operator >(Article a1, Article a2) => (a1.Price > a2.Price);
    public static bool operator <(Article a1, Article a2) => !(a1.Price > a2.Price);

    public override string ToString(){
    return $@"Product Info 
    Name:{ProductName}
    Code:{ProductCode}
    Price{Price}";
    }
}
    struct Client
    {

        public Guid ClientCode { get; set; }
        public string? FullName { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public double TotalPrice { get; set; }
        public int ItemsCount { get; set; }


    public Client(Guid ClientCode, string FullName, string Address, string Telephone, double TotalPrice,int ItemsCount):this()
    {
        this.ClientCode = ClientCode;
        this.FullName = FullName;
        this.Address = Address;
        this.Telephone = Telephone;
        this.TotalPrice = TotalPrice;
        this.ItemsCount = ItemsCount;
    }

    public static double operator +(Client a1, Client a2)
    {
        return a1.ItemsCount + a2.ItemsCount;
    }
    public static double operator -(Client a1, Client a2)
    {
        return a1.ItemsCount - a2.ItemsCount;
    }
    public static double operator *(Client a1, Client a2)
    {
        return a1.ItemsCount * a2.ItemsCount;
    }
    public static double operator /(Client a1, Client a2)
    {
        return a1.ItemsCount * a2.ItemsCount;
    }
    public static Client operator ++(Client a1)
    {
        a1.ItemsCount++;
        return a1;
    }
    public static Client operator --(Client a1)
    {
        a1.ItemsCount--;
        return a1;
    }


    public static bool operator ==(Client a1, Client a2) => (a1.TotalPrice == a2.TotalPrice);
    public static bool operator !=(Client a1, Client a2) => !(a1.TotalPrice == a2.TotalPrice);

    public static bool operator >(Client a1, Client a2) => (a1.ItemsCount > a2.ItemsCount);
    public static bool operator <(Client a1, Client a2) => !(a1.ItemsCount > a2.ItemsCount);

    public override string ToString()
    {
        return $@"Client Info 
    Code:{ClientCode}
    FullName:{FullName}
    Address:{Address}
    Telephone:{Telephone}
    Total Price:{TotalPrice}
    Items Count:{ItemsCount}";
    }

}

    class Program
    {
        static void Main()
        {

            {
                DictionarywIndexer dictionary = new();

                dictionary[0, 0] = "Hello";
                dictionary[0, 1] = "Salam";
                dictionary[1, 0] = "World";
                dictionary[1, 1] = "Dunya";
                dictionary[2, 0] = "Table";
                dictionary[2, 1] = "Masa";
                dictionary[3, 0] = "Scholarship";
                dictionary[3, 1] = "Teqaud";
                dictionary[4, 0] = "Academy";
                dictionary[4, 1] = "Akademiya";
                dictionary[5, 0] = "Entertaiment";
                dictionary[5, 1] = "Eylence";
                dictionary[6, 0] = "Book";
                dictionary[6, 1] = "Kitab";
                dictionary[7, 0] = "Notebook";
                dictionary[7, 1] = "Defter";
                dictionary[8, 0] = "Headphone";
                dictionary[8, 1] = "Qulaqciq";
                dictionary[9, 0] = "Chair";
                dictionary[9, 1] = "Stul";
                dictionary[10, 0] = "Cotton";
                dictionary[10, 1] = "Pambiq";
                dictionary[11, 0] = "Country";
                dictionary[11, 1] = "Olke";
                dictionary[12, 0] = "City";
                dictionary[12, 1] = "Seher";
                dictionary[13, 0] = "Capital";
                dictionary[13, 1] = "Paytaxt";
                dictionary[14, 0] = "Main";
                dictionary[14, 1] = "Esas";
                dictionary[15, 0] = "Catch";
                dictionary[15, 1] = "Tutmaq";

                Console.WriteLine(dictionary[0, 0]);
            }



            {
            Article a1 = new()
            {
                ProductCode = Guid.NewGuid(),
                ProductName = "Name1",
                Price = 1500

            };
            Article a2 = new()
            {
                ProductCode = Guid.NewGuid(),
                ProductName = "Name2",
                Price = 200

            };
            Console.WriteLine(a1+a2);
            Console.WriteLine(a1-a2);
            Console.WriteLine(a1*a2);
            Console.WriteLine(a1/a2);
            Console.WriteLine(a1>a2);
            Console.WriteLine(a1<a2);
            Console.WriteLine(a1==a2);
            Console.WriteLine(a1!=a2);


            }



            {
            Client c1 = new()
            {

                ClientCode = Guid.NewGuid(),
                FullName="Name1",
                Address="Address1",
                TotalPrice=140,
                Telephone="12131313",
                ItemsCount=4

            };
            Client c2 = new()
            {

                ClientCode = Guid.NewGuid(),
                FullName = "Name2",
                Address = "Address2",
                TotalPrice = 208,
                Telephone = "131414132",
                ItemsCount = 7

            };
            Console.WriteLine(c1 + c2);
            Console.WriteLine(c1 - c2);
            Console.WriteLine(c1 * c2);
            Console.WriteLine(c1 / c2);
            Console.WriteLine(c1 > c2);
            Console.WriteLine(c1 < c2);
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1 != c2);






        }
    }
    }





