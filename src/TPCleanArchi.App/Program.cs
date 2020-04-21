using System;
using TPCleanArchi.Core;

namespace TPCleanArchi.App
{
    class Program
    {
        static void Main(string[] args)
        {
            ToDoList toDoList = new ToDoList();

            // if(args.Length > 0) 
            // {
            //     if(args[0] == "get")
            //     {
            //         Console.WriteLine("GET from DB");
            //         string[] lines = new ReadToFile().ReadLines();

            //         foreach (string line in lines)
            //         {
            //             // Use a tab to indent each line of the file.
            //             Console.WriteLine(">" + line);
            //         }
            //     }
            //     else if(args[0] == "add" && args[1] != null)
            //     {
            //         Console.WriteLine("ADD " + args[1] + " to DB");

            //         Mark mark = new Mark(args[1]);
            //         toDoList.AddMark(mark);
            //     }
            // }

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