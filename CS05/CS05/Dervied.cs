namespace CS05
{
    public class Dervied : Base
    {
        public  void early()
        {
            Console.WriteLine("I'm early static binding dervied");
        }
        public override void Late()
        {
            Console.WriteLine("I'm late dynamic binding Dervied");
        }
    }
}
