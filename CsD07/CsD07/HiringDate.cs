namespace CsD07
{
    public struct HireDate : IComparable<HireDate>
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        public int CompareTo(HireDate other)
        {
            if (Year != other.Year)
                return Year.CompareTo(other.Year);
            if (Month != other.Month)
                return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }
    }


}