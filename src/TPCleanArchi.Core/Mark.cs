using System;

namespace TPCleanArchi.Core
{
    public class Mark
    {
        public string Text {get; set;}
        public DateTime Date {get; set;}
        public bool Done {get; private set;}

        public Mark(string text, DateTime? date = null)
        {
            this.Text = text;
            if (!date.HasValue)
                this.Date = ApplicationTime.Now;
            else
                this.Date = date.Value;
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
            string result="";
            TimeSpan timeDiff = GetDiff();
            if(timeDiff.Days != 0){
                result+=$"[{timeDiff.Days} d],";
            }
            if(timeDiff.Hours != 0){
                result+=$"[{timeDiff.Hours} h],";
            }
            if(timeDiff.Minutes != 0){
                result+=$"[{timeDiff.Minutes} min],";
            }
            if(timeDiff.Seconds != 0){
                result+=$"[{timeDiff.Seconds} s],";
            }
            return result + this.Text;
        }
    }
}