using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7
{
    internal class Duration
    {
        private int Hours { get; set; }
        private int Minutes { get; set; }
        private int Seconds { get; set; }
        public Duration(int x) {
            float f1 = (float)x / 3600;
            Hours = (int)f1;
            float f2 = f1 - (int)f1;
            Minutes = (int)(f2*60);
            float f3 =f2 * 60 - (int)(f2 * 60);
            Seconds= (int)(f3 * 60);
        }
        public Duration(int x,int y,int z)
            {
            Hours = x;
            Minutes = y;
            Seconds = z;
          }
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;// the change in behavior
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {

            return HashCode.Combine(Hours, Minutes, Seconds);
        }
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
        }

        public int TotalSeconds => Hours * 3600 + Minutes * 60 + Seconds;
        public static Duration operator +(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return new Duration(total1 + total2);
        }

        public static Duration operator +(Duration d, int seconds)
        {
            int total = d?.TotalSeconds ?? 0;
            return new Duration(total + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            int total = d?.TotalSeconds ?? 0;
            return new Duration(total + seconds);
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return new Duration(Math.Max(0, total1 - total2));
        }

        public static Duration operator ++(Duration d)
        {
            int total = d?.TotalSeconds ?? 0;
            return new Duration(total + 60);
        }

        public static Duration operator --(Duration d)
        {
            int total = d?.TotalSeconds ?? 0;
            return new Duration(Math.Max(0, total - 60));
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return total1 > total2;
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return total1 < total2;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return total1 >= total2;
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            int total1 = d1?.TotalSeconds ?? 0;
            int total2 = d2?.TotalSeconds ?? 0;
            return total1 <= total2;
        }

        public static bool operator true(Duration d)
        {
            return (d?.TotalSeconds ?? 0) > 0;
        }

        public static bool operator false(Duration d)
        {
            return (d?.TotalSeconds ?? 0) == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return DateTime.Today.AddSeconds(d?.TotalSeconds ?? 0);
        }
    }
}
