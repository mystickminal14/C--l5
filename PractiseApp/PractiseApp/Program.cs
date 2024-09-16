namespace PractiseApp
{
    internal class Program
    {
        public class First
        {
            public static int average(int x, int y)
            {
                return (x + y) / 2;
            }
        }
        public static void Main(string[] args)
        {
 
            int average = First.average(2, 4);  
            Console.WriteLine(average);
        }
    }
}
