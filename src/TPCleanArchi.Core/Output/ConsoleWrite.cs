using System;

public class ConsoleWrite : IOutup 
{
    public void Write(string message) => Console.WriteLine(message);
}