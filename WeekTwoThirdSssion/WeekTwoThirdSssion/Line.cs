using System.Collections;
using System.Collections.Generic;

namespace WeekTwoThirdSssion
{
    public class Line : IEnumerable<int>
    {
        Point start = new Point();
        Point end = new Point();
        private List<int> coordinates = new List<int>();

        public Point Start
        {
            get { return start; }
            set { start = value; }
        }
        public Point End
        {
            get { return end; }
            set { end = value; }
        }

        public Line() { } 

        public Line(int x1, int y1, int x2, int y2)
        {
            start.X = x1;
            start.Y = y1;
            end.X = x2;
            end.Y = y2;
           
        }
        #region implementation of IEnumrebale interface
        public void Add(int coordinate)
        {
            coordinates.Add(coordinate);
            if (coordinates.Count <= 2)
            {
                if (coordinates.Count == 1) start.X = coordinate;
                if (coordinates.Count == 2) start.Y = coordinate;
            }
            else
            {
                if (coordinates.Count == 3) end.X = coordinate;
                if (coordinates.Count == 4) end.Y = coordinate;
            }
        }

        public IEnumerator<int> GetEnumerator()
        {
            return coordinates.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        #endregion
        public string PrintLine()
        {
            return $"Line start {start.PrintPoint()} , End {end.PrintPoint()}";
        }

    }
}