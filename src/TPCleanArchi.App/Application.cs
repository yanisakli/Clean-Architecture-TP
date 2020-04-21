using System;
using TPCleanArchi.Core;

namespace TPCleanArchi.App
{
    public class Application
    {
        IOutput output;
        ReadToFile readToFile;
        WriteToFile writeToFile;
        ToDoList toDoList;

        public Application(IOutput output)
        {
            this.output = output;
            this.readToFile = new ReadToFile();
            this.writeToFile = new WriteToFile();
            this.toDoList = new ToDoList();
        }

        public void GetMarks(DateTime dateTime)
        {
            output.Write("GET from DB");
            string[] lines = this.readToFile.ReadLines();
            string[] dates;

            foreach (var line in lines)
            {
                dates = line.Split(" ");
                if(dateTime > Convert.ToDateTime(dates[0])){
                    output.Write($"{line}");
                }
            }
        }

        public void AddMark(string text)
        {
            output.Write($"ADD {text} to DB");
            Mark mark = new Mark(text);
            this.toDoList.AddMark(mark);
            this.writeToFile.WriteLine($"{mark}");
        }
    }
}