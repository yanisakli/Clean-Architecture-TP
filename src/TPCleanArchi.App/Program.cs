using System;

namespace TPCleanArchi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 1) 
            {
                if(args[0] == "get")
                {
                    Console.WriteLine("GET");
                }
                else if(args[0] == "add")
                {
                    Console.WriteLine("ADD " + args[1]);
                }
            }         
        }
    }
}
