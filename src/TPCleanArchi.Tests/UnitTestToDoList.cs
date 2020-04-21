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

        [Fact]
        public void Should_find_todo_list_in_order()
        {
            ToDoList ToDoList = new ToDoList();
            Mark OldMark = new Mark("OldMark");
            Mark NewMark = new Mark("NewMark");
            ToDoList.AddMark(OldMark);
            ToDoList.AddMark(NewMark);
            Assert.Equal(OldMark, ToDoList.listMarks[0]);
            Assert.Equal(NewMark, ToDoList.listMarks[1]);
        }
    }
}
