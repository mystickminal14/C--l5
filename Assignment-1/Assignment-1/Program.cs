namespace Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name : ");
            string userName = Console.ReadLine();

            Console.Write("Enter your age : ");
            string userAge = Console.ReadLine();

            Console.Write("Enter your favourite number : ");
            string userFav = Console.ReadLine();
            int age = Convert.ToInt32(userAge);
            int favNum = Convert.ToInt32(userFav);

            Console.WriteLine($"Happy Birthday!! Congratulations for turning {age}");
            Remaining(age);
            EvenOrOdd(age);

        }
        public static void Remaining(int age){
            Console.WriteLine($"The remaining age left to reach 100 is : {100-age}");

            }
        public static void EvenOrOdd(int age)
        {
            if (age % 2 == 0) {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("ODD");
            }

        }
    }

}
