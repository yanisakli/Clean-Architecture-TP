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
            Mark mark = new Mark("mark1",testDate);

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
            ApplicationTime.SetNow = () => new DateTime(2020, 03, 10, 10, 40, 00);
            Mark mark = new Mark("mark1",new DateTime(2020, 03, 10, 10, 00, 00));
            Assert.Equal("[40 min],mark1", mark.FormatDate());
        }

        [Fact]
        public void Should_be_1day_1hour_1mn_1s_1ms_min_old()
        {
            ApplicationTime.SetNow = () => new DateTime(2020, 03, 10, 10, 10, 10);
            Mark mark = new Mark("mark2",new DateTime(2020, 03, 9, 9, 9, 9));
            Assert.Equal("[1 d],[1 h],[1 min],[1 s],mark2", mark.FormatDate());
        }

        [Fact]
        public void should_return_31_days()
        {
            ApplicationTime.SetNow = () => new DateTime(2020, 06, 10, 10, 00, 00);
            Mark mark = new Mark("mark1",new DateTime(2020, 05, 10, 10, 00, 00));
            Assert.Equal(31, mark.GetDiff().Days);
        }
    }
}
