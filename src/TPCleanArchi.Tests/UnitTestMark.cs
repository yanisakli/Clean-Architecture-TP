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
            DateTime testDate = new DateTime(2020, 03, 10, 10, 00, 00);
            ApplicationTime.SetNow = () => testDate;
            Mark mark = new Mark("mark1");

            Assert.Equal(false, mark.Done);
            Assert.Equal("mark1", mark.Text);
            Assert.Equal(testDate, mark.Date);
        }

        [Fact]
        public void Should_marks_as_done_one_mark()
        {
            DateTime testDate = new DateTime(2020, 03, 10, 10, 00, 00);
            ApplicationTime.SetNow = () => testDate;
            Mark mark = new Mark("mark1");

            mark.SetDone();

            Assert.Equal(true, mark.Done);
        }

        [Fact]
        public void Should_be_40_min_old()
        {
            ApplicationTime.SetNow = () => new DateTime(2020, 03, 10, 10, 00, 00);
            Mark mark = new Mark("mark1");
            string resultDiff = mark.ToString();
            Assert.Equal("[40 min] mark1",resultDiff);

        }

        [Fact]
        public void should_format_correctly()
        {
            ApplicationTime.SetNow = () => new DateTime(2020, 03, 10, 10, 00, 00);
            Mark mark = new Mark("mark1");
            string resultDiff = mark.FormatDate();
            Assert.Equal("[40 min] mark1",resultDiff);

        }
    }
}
