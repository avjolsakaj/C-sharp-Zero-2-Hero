Console.WriteLine("Enter your name:");

string name = Console.ReadLine();

Console.WriteLine("Enter your Age:");

string age = Console.ReadLine();

// int ageNumber = int.Parse(age);
/*
First line
Second line
*/
var valid = int.TryParse(age, out int ageNumber);

if (valid)
{
    // Console.WriteLine("Hello " + name);
    Console.WriteLine($"Hello {name}, your age is {ageNumber}");
}
else
{
    Console.WriteLine("This is not a valid age, program is finished!");
}
