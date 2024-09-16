using Microsoft.VisualBasic;
using System.ComponentModel.Design;

namespace PraCTISE
{
    //superclass
    public class Car()
    {

        public string name;

        public void sleep(string address,int age)
        {
            Console.WriteLine($"My name is {name} and my address {address} and age is{age}");

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Car tesla = new Car();
            tesla.name = "Tesla";
            tesla.sleep("Kathmandu",1);

            Car hyundai = new Car();
            hyundai.name = "Hyundai";
            hyundai.sleep("China",1);

        }
    }
}
