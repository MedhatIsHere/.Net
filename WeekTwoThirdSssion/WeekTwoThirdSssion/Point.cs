namespace WeekTwoThirdSssion
{
    public class Point
    {
        int x;
        int y;
       public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
            
        }

        public Point() {
            X = Y = default;
        }
        public string PrintPoint()
        {
            return $"({x},{y})";
        }
    }
}
