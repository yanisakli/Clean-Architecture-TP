using System;
using Xunit;
using TPCleanArchi.Core;

namespace TPCleanArchi.Tests
{
    public class UnitTestMark
    {
        [Fact]
        public void Should_create_one_mark()
        {
            Mark mark = new Mark("mark1");

            Assert.Equal(false, mark.done);
            Assert.Equal("mark1", mark.Text);
        }
    }
}
