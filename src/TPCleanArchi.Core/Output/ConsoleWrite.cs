using System;

public class ConsoleWrite : IOutput 
{
    public void Write(string message) => Console.WriteLine(message);
}