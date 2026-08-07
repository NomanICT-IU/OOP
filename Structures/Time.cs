using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    public struct Time
    {
        private int _hour, _minute, _second;

        public Time(int hour, int minute,int second):this()
        {
            _hour = hour;
            _minute = minute;
            
        }
        public Time()
        {
            _second = second;
        }

        public int Hour { get => _hour; }
        public int Minute { get => _minute; }
        public int Second { get => _second; }

        public string GetTime()
        {
            return ($"Hours: {Hour}, Minutes: {Minute}, Second: {Second}");
        }
    }
}
