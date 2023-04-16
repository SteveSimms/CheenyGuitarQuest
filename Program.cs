//TODO: Use this code as an example you can modify it to fit your needs or use it as a reference to create your own program.
//See the instructions.md file to get a step by step guide on how to create your own program.
string name;
int age;

Console.WriteLine("What is your name?");
name = Console.ReadLine();
Console.WriteLine("What is your age?");
age = int.Parse(Console.ReadLine());


Console.WriteLine($"Hello {name}, you are {age} years old");

 if (age < 18)
 {
     Console.WriteLine("That's great {name}, Take guitar lessons and stay in school");
 }
 else if (age > 18)
 {
     Console.WriteLine($"That's great {name}. Take lessons, " +
                       $"Jam on guitar more and be down with the auto-bots," +
                       $" click one of these links and be inspired to shred!" +
                       $"https://www.youtube.com/watch?v=VcwI04mIN8k, https://www.youtube.com/watch?v=O7MPxu0Us5Q");
 }

 
 
