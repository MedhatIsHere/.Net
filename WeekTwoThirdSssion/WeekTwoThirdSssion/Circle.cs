namespace WeekTwoThirdSssion
{
    public class Circle
    {
        Point center;
        int radius;

        public Point Center
        {
            get
            {
                return center;
            }

            set
            {
                center = value;
            }
        }

        public int Radius
        {
            get
            {
                return radius;
            }

            set
            {
                radius = value;
            }
        }

        public Circle()
        {
            center = default;
            radius = default;
        }
        public Circle(int x1, int y1, int _radius)
        {
            center = new Point(x1, y1);
            radius = _radius;
        }

        public string PrintCircle()
        {
            return $" center {center.PrintPoint()} , raduis {radius}";
        }
    }
}
