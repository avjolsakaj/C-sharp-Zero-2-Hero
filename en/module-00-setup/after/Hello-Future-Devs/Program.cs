// Program.cs — Module 0 After (EN)
// This is the completed version of the first console app.
// It prints a personalized message, today’s date, and a learning goal.

Console.WriteLine($"Hello from {Environment.UserName}! Today is {DateOnly.FromDateTime(DateTime.Today):yyyy-MM-dd}.");
Console.WriteLine("Goal: Learn C#, one small step at a time.");