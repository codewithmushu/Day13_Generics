using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_Max
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1 - Given 3 Integers, find the maximum");
            Console.WriteLine("2 - Given 3 Floats, find the maximum");
            Console.WriteLine("8 - Exit");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindMax<int>(3, 7, 1);
                    break;
                case 2:
                    FindMax<float>(3.5f, 7.2f, 1.3f);
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }

            void FindMax<T>(T value1, T value2, T value3) where T : IComparable<T>
            {
                T max = value1;

                if (value2.CompareTo(max) > 0)
                    max = value2;

                if (value3.CompareTo(max) > 0)
                    max = value3;

                Console.WriteLine($"The maximum value is: {max}");
            }
        }
    }
}
