using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_second_ed
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BMI Calculator");
            Console.WriteLine();
            Console.WriteLine("Tom Jefferson has an age of 19, his wieght is 50kg and his height is 156,5cm. ");

            Console.WriteLine("Enter age of Tom here:");
            string age = Console.ReadLine();

            Console.WriteLine(" Enter Toms weight in kg here:");
            string weight = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter Toms height in cm here:");
            string height = Console.ReadLine();

            float w = float.Parse(weight);
            float h = float.Parse(height);

            float meter = h * 0.01f;
            float square = meter * meter;
            float bmi = w / square;
            Console.WriteLine("Toms bmi is:");
            Console.WriteLine(bmi);
            Console.WriteLine();

            Console.WriteLine("Enter your name: ");
            string age1 = Console.ReadLine();

            Console.WriteLine("Enter your weight:");
            string weight1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter your height in cm here:");
            string height1 = Console.ReadLine();
            Console.WriteLine();


            float w1 = float.Parse(weight1);
            float h1 = float.Parse(height1);

            float meter1 = h1 * 0.01f;
            float square1 = meter1 * meter1;
            float bmi1 = w1 / square1;
            Console.WriteLine("You have a bmi of:");
            Console.WriteLine(bmi1);
            Console.WriteLine();





        }   
    }
}
