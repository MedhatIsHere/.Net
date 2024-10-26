namespace WeekTwoThirdSssion
{
    public class Rectangle
    {
        public Point Ul {  get; set; }
        public Point Lr { get; set; }

        public Rectangle()
        {
            Ul = Lr = default;
        }
        public Rectangle(int x1, int y1, int x2,int y2) {
            
             Ul = new Point(x1, y1);
             Lr = new Point(x2, y2);
        }
       
        public string PrintRect()
        {
            return $" Rectangle Line start {Ul.PrintPoint()} , End {Lr.PrintPoint()}";
        }
    }
}
