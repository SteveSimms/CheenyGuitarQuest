WriteLine("What is your age?");
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

Advanced

Ask Copilot
RESULT
Here is the explanation for the code above:

1. Create a string variable called name and an integer variable called age
2. Ask for the user's name and save it in the name variable
3. Ask for the user's age and save it in the age variable
4. Print out the greeting "Hello" and the user's name
5. If the user is under 18, print out "That's great (name), Take guitar lessons and stay in school"
6. If the user is over 18, print out "That's great (name). Take lessons, Jam on guitar more and be down with the auto-bots, click one of these links and be inspired to shred! https://www.youtube.com/watch?v=VcwI04mIN8k, https://www.youtube.com/watch?v=O7MPxu0Us5Q"
