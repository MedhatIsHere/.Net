namespace CS05
{
    public class Rect : GeoShape
    {
        public Rect()
        {
            Console.WriteLine("Rect def ctor");
        }
        public Rect(int _d1, int _d2) : base(_d1, _d2)
        {
            
            Console.WriteLine("rect 2p ctor");
        }
       
    }
}
