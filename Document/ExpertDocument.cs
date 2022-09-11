namespace ExpertDoc;
using ProDocument;
class ExpertDocument : ProDocument
{
public override void SaveDocument() => Console.WriteLine("Document Saved in pdf format");
}
