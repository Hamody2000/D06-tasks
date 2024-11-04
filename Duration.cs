using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace taskD06
{
    public class Duration
    {
        int hours;
        int minutes;
        int seconds;

        public int Seconds
        {
            get
            {
                return seconds;
            }

            set
            {
                seconds = value;
            }
        }

        public int Hours
        {
            get
            {
                return hours;
            }

            set
            {
                hours = value;
            }
        }

        public int Minutes
        {
            get
            {
                return minutes;
            }

            set
            {
                minutes = value;
            }
        }


        public Duration()
        {

        }

        public Duration(int _hours, int _minutes, int _seconds)
        {
            hours = _hours;
            minutes = _minutes;
            seconds = _seconds;
        }

        public Duration(int _seconds)
        {


            seconds = _seconds;

        }

        public override string ToString()
        {
            if (seconds > 59)
            {
                minutes += seconds / 60;
                seconds %= 60;
            }
            if (minutes > 59)
            {
                hours += minutes / 60;
                minutes %= 60;
            }
            return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
        }

        public static Duration operator +(Duration left, Duration right)
        {
            Duration result = new Duration();
            result.seconds = left.seconds + right.seconds;
            result.Hours = left.hours + right.hours;
            result.Minutes = left.minutes + right.minutes;
            return result;
        }
        public static Duration operator +(Duration left, int num)
        {
            Duration result = new Duration();
        
            result.seconds = left.seconds+ num;
            return result;
        }
        public static Duration operator +(int num, Duration right)
        {
            Duration result = new Duration();
            result.seconds = right.seconds + num;
            return result;
        }


        public static Duration operator ++(Duration left)
        {
            return new Duration() { Minutes = left.Minutes + 1 };
        }

        public static Duration operator --(Duration left)
        {
            return new Duration() { Minutes = left.Minutes - 1 };
        }

        public static bool operator >(Duration left, Duration right)
        {
            return left.Minutes > right.Minutes && left.Seconds > right.Seconds && left.Hours > right.Hours;
        }
        public static bool operator <(Duration left, Duration right)
        {
            return left.Minutes < right.Minutes && left.Seconds < right.Seconds && left.Hours < right.Hours;
        }

    }
}
