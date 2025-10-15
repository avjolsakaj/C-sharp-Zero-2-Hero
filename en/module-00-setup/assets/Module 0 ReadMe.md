## Module 0 — Setup & First Run
### Goal
- Install **.NET 9 SDK**, **Visual Studio Code**, and required C# Dev Kit Extension.
- Create and run a console app using the UI.
- Edit `Program.cs` and rerun the program.
- Print custom text with today’s date.

### Step-by-Step Instructions
1. Install **.NET 9 SDK** from Microsoft’s website. [Download .NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
2. Install **Visual Studio Code**. [Download VS Code](https://code.visualstudio.com/)
3. Add extensions: **C# Dev Kit** and **.NET Install Tool**. [C# Dev Kit Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
4. Open **Command Palette** → *New Project* → Console App. [Command Palette Guide](https://code.visualstudio.com/docs/getstarted/userinterface#_command-palette)
5. Name the project (e.g., `Hello-Future-Devs`).
6. Run ▶️ using *Run and Debug*. [Run & Debug Guide](https://code.visualstudio.com/docs/editor/debugging)
7. Edit `Program.cs` to print your name and today’s date.
8. Save and run again.

### Guided Exercise
- Change the program to print:
  1. Your name.
  2. Today’s date in `yyyy-MM-dd` format.
  3. A short learning goal.

Expected Output:
```
Hello from Avjol! Today is 2025-08-21.
Goal: Learn C# step by step.
```

### Exam Task
- Create a new project `HelloAgain`.
- Print greeting, today’s date, and learning message.

**Rubric:**
- Project created via UI (2 pts)
- App runs (2 pts)
- Output matches requirements (3 pts)
- No errors (2 pts)
- Bonus: uses `DateOnly` (1 pt)

### Common Issues & Fixes
- **Error: .NET not found** → Reinstall .NET 9 SDK. [Download .NET 9 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- **Run and Debug missing** → Install *C# Dev Kit*. [C# Dev Kit Extension](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csdevkit)
- **Output didn’t change** → Save before running.

### Debugging Tips
- Add breakpoint on `Console.WriteLine`. [Breakpoints Guide](https://code.visualstudio.com/docs/editor/debugging#_breakpoints)
- Run debugger, check Variables.
- Use F10 (Step Over), F11 (Step Into).

### Next Module
**Variables & Input/Output** — learning how to store and read values.
