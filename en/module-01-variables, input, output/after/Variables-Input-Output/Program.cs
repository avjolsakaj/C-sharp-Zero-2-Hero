Console.Write("What is your favorite number? ");
string? numInput = Console.ReadLine();
if (int.TryParse(numInput, out int num))
{
    Console.WriteLine($"Double your number is {num * 2}.");
}
else
{
    Console.WriteLine("That's not a number.");
}