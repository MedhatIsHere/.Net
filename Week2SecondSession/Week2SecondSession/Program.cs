using Week2SecondSession;

class Program
{
    static void Main(string[] args)
    {
        DynamicStack s1 = new(5);
        DynamicStack s2 = new(3);
        DynamicStack s3 = new(4);
        int x = 100;
        Console.WriteLine( DynamicStack.GetCounter());
     // Console.WriteLine( s1.Pop());
        s1.Push(x);
       Console.WriteLine(s1.Peak());
        Console.WriteLine(s1.IsFull);
        Console.WriteLine(s3.IsEmpty);
    }
}
