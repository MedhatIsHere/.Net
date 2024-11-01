namespace CS05
{
    public class Square : Rect
    {
        public Square()
        {
            Console.WriteLine("Sq def ctor");
        }
        public Square(int _dim1) : base(_dim1, _dim1)
        {
            Dim2 = Dim1 = _dim1;
            Console.WriteLine("Sq 2p ctor");
        }
       
       
    }
}
