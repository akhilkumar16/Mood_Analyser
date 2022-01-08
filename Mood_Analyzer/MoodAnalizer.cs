using System;
using System.Collections.Generic;
using System.Text;

namespace Mood_Analyzer
{
    public class MoodAnalizer
    {
        public string message;
        public MoodAnalizer(string message)
        {
            this.message = message;
        }
        public string AnalyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            }
            else
            {
                return "HAPPY";
            }
        }
    }
}