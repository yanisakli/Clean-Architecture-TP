using System;
using System.Collections.Generic;

namespace TPCleanArchi.Core
{
    public class ToDoList
    {
        public List<Mark> listMarks;

        public ToDoList(){
            this.listMarks= new List<Mark>();
        }

        public void AddMark(string Text){
            this.listMarks.Add(new Mark(Text));
        }

        public void RemoveMark(Mark mark){
            this.listMarks.Remove(mark);
        }
    }
}
