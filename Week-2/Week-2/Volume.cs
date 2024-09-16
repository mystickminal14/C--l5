using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class volume

    {
        private int length;
        private int breadth;
        private int height;
        public volume(int _length,int _breadth, int _height){
            length = _length;
            breadth = _breadth;
            height = _height;
            }

//        Exercise 1: Calculating the Volume of a Cylinder
//Write a C# program to calculate the volume of a cylinder. The program should meet the following requirements:

// - It should consist of two classes:
//Testing Class: Contains the Main() method.
//Volume Calculation Class: Contains a method that calculates the volume of the cylinder.
// - The program should utilize  pass-by-value to pass the parameters for volume calculation.
// - The result should be displayed in the console window.

        public void Calculate()
        {
            int Volume = length * breadth * height;
            Console.WriteLine($"THE VOLUME IS : {Volume}");
            
        }
    }
}
