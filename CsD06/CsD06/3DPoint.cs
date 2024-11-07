namespace CsD06
{
    public class Point
    {
        private int x;
        private int y;
        private int z;
        public int X
        {
            set { x = value; }

            get { return x; }
        }
        public int Y
        {
            set { y = value; }

            get { return y; }
        }
        public int Z
        {
            set { z = value; }

            get { return z; }
        }

        public Point()
        {
            x = y = z = 0;
        }

        public Point(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"Point Coordinates: ( x = {X},y = {Y}, z = {Z})";
        }

        public static explicit operator string(Point point)
        {
            return point.ToString();
        }


        public static Point ReadPoint()
        {
            Console.WriteLine("Enter X, Y, Z coordinates separated by space:");
            var input = Console.ReadLine()?.Split();
            if (input == null || input.Length != 3 ||
                !int.TryParse(input[0], out int x) ||
                !int.TryParse(input[1], out int y) ||
                !int.TryParse(input[2], out int z))
            {
                throw new FormatException("Invalid coordinates. Please enter integers separated by spaces.");
            }
            return new Point(x, y, z);
        }

        public static Point[] ReadPointsArray(int size)
        {
            Point[] points = new Point[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter coordinates for point {i + 1}:");
                points[i] = ReadPoint();
            }
            return points;
        }
      

    }
}
