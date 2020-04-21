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
                var app = new Application(new ConsoleWrite());

                if(action == "get")
                {
                    DateTime dateTime = Convert.ToDateTime(args[1]);
                    app.GetMarks(dateTime);
                }
                else if(action == "add")
                {
                    app.AddMark(args[1]);
                }
            }
        }
    }
}