In this lesson we learned about

# Creating a new project 

This was done via the dotnet cli (command line interface) we used the `new` command to create a new console project:
`dotnet new console --output Lesson1`

For an exhaustive list of commands that can be used with the cli please refer to the microsoft documentation here: https://docs.microsoft.com/en-us/dotnet/core/tools/

# How to write to a console/terminal

We learned that we have helper methods (or functions) built into the language to help us acomplish what we want to do, one of these helpers is known as the `Console` class, which belongs to the `System` namespace, and even though we have deffered learning what those words mean we know that one belongs to the other so we can write:

`System.Console.Write();`

To write a message onto the console, we have passed the message `Hello world` into this function/method via a data type known as a "string" which is represented by putting quotes around the message we are passing into the function/method:

`System.Console.Write("Hello World");`

# What else can the console do?

In future lessons we'll be exploring more of what the console class can do for us, but why not take a sneak peak, either by reading the descriptions in vscode or by looking up the documentation on the console class (not link you'll have to search ;))