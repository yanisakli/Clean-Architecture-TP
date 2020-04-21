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
            ToDoList toDoList = new ToDoList();
            toDoList.AddMark("test");
        }

        [Fact]
        public void Should_remove_one_mark_in_todo_list()
        {
            ToDoList toDoList = new ToDoList();
            Mark mark = new Mark("markTest");
            toDoList.AddMark("markTest");

        }
    }
}
