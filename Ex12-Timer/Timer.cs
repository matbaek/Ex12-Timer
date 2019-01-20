using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Timer
{
    public class Timer
    {
        int sec = 0;
        string resultToString = null;
        public int Seconds {
            get
            {
                return sec;
            }
            set
            {
                sec = value;
            }
        }

        public override string ToString()
        {
            int hours = sec / 60 / 60;
            int minutes = (sec - (hours * 3600)) / 60;
            int seconds = ((sec - (hours * 3600)) - (minutes * 60));
            if (hours < 10)
            {
                resultToString = "0" + hours;
            }
            else if (hours > 10)
            {
                resultToString = "" + hours;
            }

            if (minutes < 10)
            {
                resultToString += ":0" + minutes;
            }
            else if (minutes > 10)
            {
                resultToString += ":" + minutes;
            }

            if (seconds < 10)
            {
                resultToString += ":0" + seconds;
            }
            else if (seconds > 10)
            {
                resultToString += ":" + seconds;
            }
            return  resultToString;
        }

        public string Padded(int v)
        {
            if(v < 10)
            {
                return "0" + v;
            }
            return "" + v;
        }
    }
}
