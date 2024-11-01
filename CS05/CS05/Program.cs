using Microsoft.AspNetCore.Rewrite;
using System;


namespace CS05
{
    class Program
    {
        static void Main(string[] args)
        {

            #region class geoshape with abstract class
            // GeoShape g1 = new GeoShape();
            Rect r1 = new Rect();
            Rect r2 = new Rect(4,5);
            Console.WriteLine(r2.CArea());

            Console.WriteLine();


            Square s1 = new Square();
            Square s2 = new Square(7);
            Console.WriteLine(s2.CArea());

            Console.WriteLine();


            Tri t1 = new Tri();
            Tri t2 = new Tri(8,9);
            Console.WriteLine(t2.CArea());


            Console.WriteLine();


            Circle c1 = new Circle();
            Circle c2 = new Circle(10);
            Console.WriteLine( c2.CArea());

            Console.WriteLine();

            #endregion

            #region early and late binding
            
            Base b1 = new Dervied();


            b1.early();
            b1.Late();


            #endregion

        }
    }
}