using System;
using TPCleanArchi.Core;

namespace TPCleanArchi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 1)
            {
                var action = args[0];
                var text = args[1];
                var app = new Application(new ConsoleWrite());

                app.Run(action, text);
            }
        }
    }
}