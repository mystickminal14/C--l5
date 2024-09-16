namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a length : ");
            int length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a Breadth : ");
            int breadth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter a height : ");
            int height = int.Parse(Console.ReadLine());
            volume volume = new volume(length, breadth, height);
            volume.Calculate();

            Console.WriteLine("Enter number of times you want to run fibonacci series");
            int n=int.Parse(Console.ReadLine());
            Fibonacci.fibo(n);

            localTime london = new LondonTime();
            localTime newYork = new NewYorkTime();
            localTime tokyo = new TokyoTime();
            localTime hongKong = new HongkongTime();

            // Display the local times for each city
            
            Console.WriteLine("Current times in major stock exchanges:");

            london.DisplayTimeAndCity();
            newYork.DisplayTimeAndCity();
            tokyo.DisplayTimeAndCity();
            hongKong.DisplayTimeAndCity();
        }
    }
}
