# Hello, World

## Learning Objectives

### Questions

* What is the meaning behind the name C#?

  * The name "C sharp" was inspired by the musical notation whereby a sharp symbol indicates that the written note should be made a semitone higher in pitch. This is similar to the language name of C++, where "++" indicates that a variable should be incremented by 1 after being evaluated. The sharp symbol also resembles a ligature of four "+" symbols (in a two-by-two grid), further implying that the language is an increment of C++.

* Who is the lead architect of the development team of C#?

  * Anders Hejlsberg

* What is .NET?

  * A software framework developed by Microsoft

* What is the difference between C# and .NET?

  * C sharp is an object-oriented and type-safe programming language that can be used to write source code for C# programs, while .NET is the virtual execution system, called the common language runtime (CLR), that is in charge of building and running said programs.

### Concepts

* How to use VSCode and the integrated terminal to initialize, build and run C# projects

* How to print text and variables using `Console.Write`

## Managing C# projects in VSCode

### Opening the integrated terminal window  
To open the terminal inside VSCode press ``CTRL + ` ``

### Initializing a C# project

![](/screenshots/dotnet_new_console.png)

### Building a C# project

![](/screenshots/dotnet_build.png)

### Running a C# project

![](/screenshots/dotnet_run.png)

## Printing text and variables to screen

```
public class ConsoleWriteExamples
{
    public static void Main(string[] args)
    {
        string someText = "or you can print the string inside of a variable by using it's value\n";
        string name = "Bob";

        Console.Write("You can write explicit text which will literally print to screen\n");
        Console.Write(someText);
        Console.Write("Note that Console.Write doesn't not end with a new line");
        Console.WriteLine("But Console.WriteLine does");
        
        Console.WriteLine("This is called composite formatting:");
        Console.WriteLine("Hi {0}, how are you today?", name);
        Console.WriteLine("While this is called string interpolation:");
        Console.WriteLine($"Hi {name}, how are you today?");
        Console.WriteLine("Both produce the same result");
    }
}
```
