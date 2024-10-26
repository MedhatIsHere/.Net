using System;

namespace WeekTwoThirdSssion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Composition
            #region Line
            Point p1 = new Point();
            Line l1 = new Line { 1, 2, 3, 4 };
            Console.WriteLine(l1.PrintLine());
            #endregion
            /////////////////////////////////////
            #region Rectangle
            Rectangle r1 = new Rectangle(6, 7, 8, 9);
            Console.WriteLine(r1.PrintRect());
            #endregion
            #region Circle
            Circle c1 = new Circle(9,11,23);
            Console.WriteLine(c1.PrintCircle());
            #endregion

            #endregion

            #region aggrigation
            Point p2 = new Point(2,2); 
            Point p3 = new Point(1,1);
            Point p4 = new Point(4,4);
            Triangle tri = new Triangle(p2,p3,p4);
           Console.WriteLine( tri.PrintTri());

            #endregion


        }
    }
}