using System;

namespace TPCleanArchi.Core
{
    public class Mark
    {
        public string Text {get; set;}
        public DateTime Date {get; set;}
        public bool done {get; set;}

        public Mark(string text)
        {
            this.Text = text;
            this.Date = ApplicationTime.Now;
            this.done = false;
        }

        public TimeSpan getDiff()
        {
            return ApplicationTime.Now - this.Date;
        }

        public void setDone() 
        {
            this.done = true;
        }

        public override string ToString() 
        {
            return $"[{this.getDiff()}] {this.Text}";
        }
    }
}
