namespace CS05
{
    public class Base
    {

        public  void early()
        {
            Console.WriteLine("I'm early static binding  Base");
        }
        public virtual void Late()
        {
            Console.WriteLine("I'm late Dynamic binding Base");
        }
    }
}
