using System.Drawing;

namespace Week2SecondSession
{
    public class DynamicStack
    {
        private int[] arr;
        private int tos;
        private int size;
        private static int counter = 0;

        public static int GetCounter()
        {
            return counter;
        }


        public DynamicStack(int _size)
        {
            counter++;
            tos = 0;
            size = _size;
            arr = new int[size];
        }

    

        public void Push(int number)
        {
            
            if (!IsFull())
            {
                arr[tos] = number;
                this.tos++;
            }
            else
            {
                Console.WriteLine("FULL!!!");
            }
        }

        public int Pop()
        {
            int? result = null;
            
            if (!IsEmpty())
            {
                tos--;
                result = arr[tos];
                
            }
            else
            {
                Console.WriteLine("EMPTY!!!!");
                
            }
            return (int)result;
        }

        public bool IsFull()
        {
            return tos == size;
        }
        public bool IsEmpty()
        {
            return tos == 0;
        }
        public int Peak()
        {
            return arr[tos - 1];
        }
    }
}
