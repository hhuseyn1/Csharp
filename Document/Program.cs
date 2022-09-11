namespace Document;
using DocumentPr;
using ProDocument;
using ExpertDoc;
class Program
{
	static void Document(string? key)
	{
		switch (key)
		{
			case "standart":
                DocumentPr standartDoc= new DocumentPr();
                standartDoc.OpenDocument();
                standartDoc.SaveDocument();
                standartDoc.EditDocument();
                break;
			case "pro":
				ProDocument proDocument = new ProDocument();
				proDocument.OpenDocument();
				proDocument.SaveDocument();
				proDocument.EditDocument();
				break;
			case "expert":
                ExpertDocument expDocument = new ExpertDocument();
                expDocument.OpenDocument();
                expDocument.SaveDocument();
                expDocument.EditDocument();
                break;
			default:
				Console.WriteLine("Invalid type");
				break;
		}
	}

	static void Main()
	{
		Console.WriteLine("Welcome Document Program !!!");
		Thread.Sleep(1000);
		Console.Clear();
		string? key;
		while (true)
		{
		Console.WriteLine("Enter key: ");
			key= Console.ReadLine();
			Document(key);
		}
	}




}