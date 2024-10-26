namespace WeekTwoThirdSssion
{
    public class Triangle
    {
        Point p1;
        Point p2;
        Point p3;

        public Point P1
        {
            get
            {
                return p1;
            }

            set
            {
                p1 = value;
            }
        }

        public Point P2
        {
            get
            {
                return p2;
            }

            set
            {
                p2 = value;
            }
        }

        public Point P3
        {
            get
            {
                return p3;
            }

            set
            {
                p3 = value;
            }
        }

        public Triangle()
        {
            p1 =p2=p3= default;
           
        }

        public Triangle(Point _p1, Point _p2, Point _p3)
        {
            p1 = _p1;
            p2 = _p2;
            p3 = _p3;
        }
        public string PrintTri()
        {
            return $" P1 {p1.PrintPoint()} , P2 {p2.PrintPoint()} , P3 {p3.PrintPoint()}";
        }
    }
}
