using System;

namespace _07_Timer
{
    internal class Timer
    {
        int seconds = 0;

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

        public override string ToString()
        {
            int hours, minutes, secondsLeft;

            hours = seconds / (60 * 60);
            minutes = (seconds / 60) % 60;
            secondsLeft = seconds % 60;

            return Padded(hours) + ":" + Padded(minutes) + ":" + Padded(secondsLeft);
        }

        public string Padded(int number)
        {
            if(number <= 9)
            {
                return "0" + number;
            }
            return number.ToString();
        }
    }
}