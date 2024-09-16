namespace ConsoleApp1
{
    public enum Shipping { 
    Regular=1,
    Registered=2
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var nameOfArray = new int[3] ;
            nameOfArray[0] = 1 ;
            var mthod=Shipping.Registered ;
            Console.WriteLine($"enum {(int)mthod}");
            Console.WriteLine(nameOfArray[0]);
            Console.WriteLine(nameOfArray[1]);
        }

    
    }
}
