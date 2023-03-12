using BlogPost;


var users = new UserRepository();
var posts = new PostRepository();
var blogs = new BlogRepository();

Console.WriteLine("Создайте пользователя:");
Console.Write("Имя: ");
string name = Console.ReadLine();
var User = new User { ID = 001, Name = name };
await users.Add(User);
Console.WriteLine("Создайте свой пост \nНаименование вашего поста:  ");
string title = Console.ReadLine();
Console.Write("Сделайте запись: ");
string text = Console.ReadLine();
var Post = new Post { ID = 001, UserId = 1, Title = title, Text = text };
await posts.Add(Post);

var Blog = new Blog { User = User, Posts = new List<Post> { Post } };

