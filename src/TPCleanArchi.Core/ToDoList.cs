using System;
using System.Collections.Generic;

namespace TPCleanArchi.Core
{
    public class ToDoList
    {
        public List<Mark> listMarks;

        public ToDoList()
        {
            this.listMarks= new List<Mark>();
        }

        public void AddMark(Mark mark)
        {
            this.listMarks.Add(mark);
            new WriteToFile().WriteLine($"\n{$"[{mark.GetDiff()}] {mark.Text}"}");
        }

        public void RemoveMark(Mark mark)
        {
            this.listMarks.Remove(mark);
        }
    }
}
