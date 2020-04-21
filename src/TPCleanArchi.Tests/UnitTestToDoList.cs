using System;
using Xunit;
using TPCleanArchi.Core;

namespace TPCleanArchi.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Should_add_one_mark_in_todo_list()
        {
            ToDoList ToDoList = new ToDoList();
            Mark mark = new Mark("MarkTest");
            ToDoList.AddMark(mark);
            Assert.Contains(mark, ToDoList.listMarks);
        }

        [Fact]
        public void Should_remove_one_mark_in_todo_list()
        {
            ToDoList ToDoList = new ToDoList();
            Mark mark = new Mark("MarkTest");
            ToDoList.AddMark(mark);
            ToDoList.RemoveMark(mark);
            Assert.DoesNotContain(mark, ToDoList.listMarks);
        }
    }
}
