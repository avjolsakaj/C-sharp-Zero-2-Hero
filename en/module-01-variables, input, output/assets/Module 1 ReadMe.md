# Module 1 — Variables & Input/Output (Student Version)

Welcome back! Today we’ll learn how to store data in variables and get input from the user.

---

## Learning Outcomes
By the end of this module, you should be able to:
- Create variables to store values like text and numbers.
- Show text in the console using `Console.WriteLine()`.
- Ask the user for input with `Console.ReadLine()`.
- Change input text into numbers using `int.TryParse()`.
- Handle both valid and invalid input.

---

## Steps

1. **Declare variables**
   ```csharp
   string name;
   int age;
   ```

2. **Ask the user for their name**
   ```csharp
   Console.Write("Enter your name: ");
   name = Console.ReadLine();
   ```

3. **Ask for their age**
   ```csharp
   Console.Write("Enter your age: ");
   string ageInput = Console.ReadLine();
   ```

4. **Convert the text to a number**
   ```csharp
   bool valid = int.TryParse(ageInput, out age);
   ```

5. **Show different results depending on input**
   ```csharp
   if (valid)
   {
       Console.WriteLine($"Hello {name}, you are {age} years old.");
   }
   else
   {
       Console.WriteLine("That’s not a valid age.");
   }
   ```

---

## Exercise
Change the program so it also asks:
- “What is your favorite number?”
- If the answer is a number, print the double of it.
- If not, print “That’s not a number.”

---

## Exam Task
Create a new project called **HelloInfo**. Your program should:
1. Ask for your name.
2. Ask for your age.
3. Print both values.
4. Handle invalid ages gracefully.

**Example Output:**
```
Enter your name: Alex
Enter your age: 20
Hello Alex, you are 20 years old.
```

Or, if invalid:
```
Enter your name: Alex
Enter your age: twenty
That’s not a valid age.
```

---

## Tips
- Use `Console.Write()` when you want input on the same line.
- Always save your code before running.
- If the program closes too fast, add:
  ```csharp
  Console.ReadKey();
  ```
  at the end.

---

## What’s Next?
In the next module, we’ll learn how to make **decisions** in C# using `if` and `switch`. This will allow our programs to react differently depending on the user’s input.

