using System;

namespace TPCleanArchi.Core
{
    public class Mark
    {
        public string Text {get; set;}
        public DateTime Date {get; set;}
        public bool Done {get; private set;}

        public Mark(string text)
        {
            this.Text = text;
            this.Date = ApplicationTime.Now;
            this.Done = false;
        }

        public TimeSpan GetDiff()
        {
            return ApplicationTime.Now - this.Date;
        }

        public void SetDone()
        {
            this.Done = true;
        }

        public override string ToString() 
        {
            return $"[{this.GetDiff()}] {this.Text}";
        }

        public string FormatDate()
        {
            Console.Write(this.GetDiff());
            return "Format Date";
        }
    }
}
