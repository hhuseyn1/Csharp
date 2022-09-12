namespace Adminspace;
using Postspace;
using Notificationspace;


class Admin {
    public Guid Id { get; set; } = Guid.NewGuid();
    public string? Username { get; set; }
    public string? Email{get; set; }
    public string? Password { get; set; }
    List<Post> posts;
    List<Notification> notifications;


    public Admin(string Username,string Email,string Password)
    {
        this.Username = Username;
        this.Email = Email;
        this.Password = Password;
        

    }

    public override string ToString()
    {
        return @$"id: {Id}
Username: {Username}
Email: {Email}
Password: {Password}";
    }

}


