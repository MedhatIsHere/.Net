namespace CS05
{
    public class Tri : GeoShape
    {
        public Tri()
        {
            Console.WriteLine("Tri def ctor");
        }
        public Tri(int _base, int _height) : base(_base, _height)
        {

            Console.WriteLine("rect 2p ctor");
        }
        public double CArea()
        {
            return 0.5 * Dim1 * Dim2;
            
        }
    }
}
