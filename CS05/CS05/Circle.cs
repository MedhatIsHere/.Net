namespace CS05
{
    public sealed class Circle : GeoShape
    {
        public Circle()
        {
            Console.WriteLine("circle def cort");
        }
        public Circle(int _radius) : base(_radius, _radius)
        {
            Console.WriteLine("circle 2p cort");
        }
        public double CArea()
        {
            return Math.PI * Dim1 * Dim2;
           
        }
    }
}
