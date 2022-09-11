namespace ProDocument;
using DocumentPr;
class ProDocument : DocumentPr
{
    public sealed override void EditDocument()=> base.EditDocument();
    public override void SaveDocument() => Console.WriteLine("Document Saved in doc format, for pdf format buy Expert packet");

}