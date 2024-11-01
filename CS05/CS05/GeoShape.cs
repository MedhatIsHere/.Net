namespace CS05
{
    public abstract class GeoShape
    {
        protected int dim1;
        protected int dim2;
        public int Dim1 {  
            get { return dim1; } 
            set { dim1 = value; }
        }
        public int Dim2 {
            get { return dim2; }
            set { dim2 = value; }
        }
        public GeoShape() { 
        dim1 = 0; 
        dim2 = 0;
            Console.WriteLine("GeoShape defult cort");
         
        }

        public GeoShape(int _dim1, int _dim2) { 
        dim1 = _dim1;
        dim2 = _dim2;
            Console.WriteLine("GeoShape 2p cort");
        }
        public int CArea() { 
        return dim1*dim2;
        }

    }
}
