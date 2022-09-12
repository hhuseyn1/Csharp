namespace NotSystem;
using Adminspace;
using Userspace;
using Postspace;
using Notificationspace;

class Program
{

    static void Main()
    {
        string? name;
        string? surname;
        string? username;
        string? email;
        string? password;
        short age = default;
        List<Post> posts = new List<Post>();
        List<Notification> notifications = new List<Notification>();

        Post post1 = new(1, "Car", new DateTime(2022, 09, 12), 1823, 2400);
        Post post2 = new(2, "Bus", new DateTime(2022, 09, 09), 758, 1982);
        Post post3 = new(3, "Programming", new DateTime(2022, 09, 01), 3421, 4578);
        posts.Add(post1);
        posts.Add(post2);
        posts.Add(post3);

        Notification not1 = new("Error", new DateTime(2022, 09, 10), "User1");
        Notification not2 = new("Message", new DateTime(2022, 09, 09), "User2");
        Notification not3 = new("Like", new DateTime(2022, 09, 03), "User3");
        notifications.Add(not1);
        notifications.Add(not2);
        notifications.Add(not3);


        while (true)
        {
            Console.WriteLine(@$"[1]Admin
[2]User");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Enter username: ");
                username = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                email = Console.ReadLine();
                if (!email.EndsWith(".com"))
                    throw new Exception("Invalid email");
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
                if (password.Length < 8)
                    throw new Exception("Length error");

                Admin admin = new Admin(username, email, password);

            }

            else if (choice == 2)
            {
                int choice2;
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                Console.WriteLine("Enter surname: ");
                surname = Console.ReadLine();
                Console.WriteLine("Enter email: ");
                email = Console.ReadLine();
                if (!email.EndsWith(".com"))
                    throw new Exception("Invalid email");
                Console.WriteLine("Enter password: ");
                password = Console.ReadLine();
                if (password.Length<8)
                    throw new Exception ("Length error");
                Console.WriteLine("Enter age: ");
                age = Convert.ToInt16(Console.ReadLine());

                User user = new User(email, name, surname, password, age);

                Thread.Sleep(1000);
                Console.Clear();

                for (int i = 0; i < posts.Count; i++)
                {
                    Console.WriteLine(posts[i].ToString());
                }
                Console.WriteLine("Enter post id which one you want to like(else 0): ");
                int id;
                id =Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < posts.Count; i++)
                {
                    if (id == posts[i].Id)
                    {
                        posts[i].LikeCount += 1;
                        Console.WriteLine($"Post id {posts[i].Id} liked");
                        break;
                    }
                    
                }
                Thread.Sleep(1000);
                Console.Clear();
            }

            else
            {
                Console.WriteLine("Invalid choice");
                Thread.Sleep(1000);
                Console.Clear();
            }
        }

    }
}
