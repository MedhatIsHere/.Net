using System.Numerics;
namespace CsD06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Point class
            //Point p1 = new Point();
            //Console.WriteLine(p1.ToString());
            //Point p2 = new Point(22, 33, 44);
            //Console.WriteLine(p2.ToString());
            //Console.WriteLine(Point.ReadPoint());
            //Point[] points = Point.ReadPointsArray(3);

            //Console.WriteLine("Entered Points:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}
            #endregion


            #region Math
            //Math math = new Math(); 

            //Console.WriteLine($"Add: {math.Add(10, 5)}");
            //Console.WriteLine($"Subtract: {math.Subtract(10, 5)}");
            //Console.WriteLine($"Multiply: {math.Multiply(10, 5)}");
            //Console.WriteLine($"Divide: {math.Divide(10, 5)}");

            #endregion


            #region modified math
            //Console.WriteLine($"Add: {MMath.Add(10, 5)}");
            //Console.WriteLine($"Subtract: {MMath.Subtract(10, 5)}");
            //Console.WriteLine($"Multiply: {MMath.Multiply(10, 5)}");
            //Console.WriteLine($"Divide: {MMath.Divide(10, 5)}");
            #endregion


            #region Duration
            Duration d1 = new Duration(1, 10, 15);
            Console.WriteLine(d1.ToString()); 

            Duration d2 = new Duration(3600);
            Console.WriteLine(d2.ToString());  

            Duration d3 = new Duration(7800);
            Console.WriteLine(d3.ToString()); 

            Duration d4 = new Duration(666);
            Console.WriteLine(d4.ToString()); 

            
            d3 = d1 + d2;
            Console.WriteLine(d3.ToString());

            d3 = d1 + 7800;
            Console.WriteLine(d3.ToString()); 

            d3 = 666 + d3;
            Console.WriteLine(d3.ToString()); 

            d3 = d1++;
            Console.WriteLine(d3.ToString()); 

            d3 = --d2;
            Console.WriteLine(d3.ToString()); 

            Console.WriteLine(d1 > d2); 
            Console.WriteLine(d1 <= d2); 
            #endregion

        }
    }
}