namespace CsD06
{
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        
        public Duration() { }

        
        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

      
        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            totalSeconds %= 3600;
            Minutes = totalSeconds / 60;
            Seconds = totalSeconds % 60;
        }

        
        public override string ToString()
        {
            if (Hours > 0)
            {
                return $"Hours: {Hours}, Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else if (Minutes > 0)
            {
                return $"Minutes: {Minutes}, Seconds: {Seconds}";
            }
            else
            {
                return $"Seconds: {Seconds}";
            }
        }

        
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Duration other = (Duration)obj;
            return Hours == other.Hours && Minutes == other.Minutes && Seconds == other.Seconds;
        }

       
        public static Duration operator +(Duration d1, Duration d2)
        {
            int totalSeconds = d1.ToTotalSeconds() + d2.ToTotalSeconds();
            return new Duration(totalSeconds);
        }

        public static Duration operator +(Duration d1, int seconds)
        {
            int totalSeconds = d1.ToTotalSeconds() + seconds;
            return new Duration(totalSeconds);
        }

        
        public static Duration operator +(int seconds, Duration d1)
        {
            return d1 + seconds;
        }

      
        public static Duration operator ++(Duration d)
        {
            int totalSeconds = d.ToTotalSeconds() + 60;
            return new Duration(totalSeconds);
        }

        public static Duration operator --(Duration d)
        {
            int totalSeconds = d.ToTotalSeconds() - 60;
            return new Duration(totalSeconds);
        }

        
        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        
        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        
        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        
        private int ToTotalSeconds()
        {
            return (Hours * 3600) + (Minutes * 60) + Seconds;
        }
    }
}
