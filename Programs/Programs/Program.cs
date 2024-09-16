using System.Security.Cryptography.X509Certificates;

namespace Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "MINALE";
            Console.WriteLine(a.GetHashCode());
            a = "KAI";

            Console.WriteLine(a.GetHashCode());

         
        }
    }
}
