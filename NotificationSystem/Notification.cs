namespace Notificationspace;

class Notification
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Text{ get; set; }
    public DateTime DateTime { get; set; }
    public string? FromUser { get; set; }

    public Notification(string Text,DateTime DateTime,string FromUser)
    {
        this.Text = Text;
        this.DateTime = DateTime;
        this.Text = Text;
    }

    public override string ToString()
    {
return @$"Text: {Text}
Time: {DateTime}
User: {FromUser}
";
    }

}



