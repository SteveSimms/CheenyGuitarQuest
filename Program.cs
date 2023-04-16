// user should be asked their name and age
// user should be promppted to enter their name and age
// if user is under 18, they should be told to take guitar lessons and stay in school
// if user is over 18, they should be told to Take lessons Jam on guitar more and be downwith the autobots and presented with a list of guitar brands and links to cool guitar solos on youtube
string name;
int age;

Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("What is your age?");
age = int.Parse(Console.ReadLine());

User newUser = new User(name, age);

Console.WriteLine($"Hello {newUser.Name}, you are {newUser.Age} years old");

 if (newUser.Age < 18)
 {
     Console.WriteLine("That's great {user.Name}, Take guitar lessons and stay in school");
 }
 else if (newUser.Age > 18)
 {
     Console.WriteLine($"That's great {newUser.Name}. Take lessons, Jam on guitar more and be down with the auto-bots");
 }

 
 
 public class User
 {
     public User(string name, int age)
     {
         Name = name;
         Age = age;
     }
     public string Name { get; set; } = String.Empty;
     public int Age { get; set; }
 }