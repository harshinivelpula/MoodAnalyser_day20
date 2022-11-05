﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moodanalyser
{
    internal class Mood
    {
        public string message;

        public Mood(string msg)
        {
            this.message = msg;
        }
        public string AnalyseMood(string msg)
        {

            if (msg.Length > 0)
            {
                message = msg;
            }
            if (msg.Contains("happy", StringComparison.OrdinalIgnoreCase))
            {
                return "happy";
            }
            if (msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }

            return null;
        }
        public string AnalyseAnyMood(string msg)
        {

            if (msg.Length > 0)
            {
                message = msg;
            }

            if (msg.Contains("sad", StringComparison.OrdinalIgnoreCase))
            {
                return "sad";
            }
            else
            {
                return "happy";
            }
            return null;
        }

    }
}
    
