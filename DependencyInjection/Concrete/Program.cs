namespace DependencyInjection.Concrete
{
    public class Program
    {
        static void Main(string[] args)
        {
            Somebody somebody = new Somebody(new Coat());
            somebody.Display();
            Console.WriteLine("------------");
            Somebody somebodyj = new Somebody(new JeanJacket());
            somebodyj.Display();
        }
    }
}