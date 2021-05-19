using System;
using Laba7Lib;
namespace Laba7_OOP_new
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vozniak Sofiia, is-01");
            Exept[] arr = new Exept[3];
            arr[0] = new Exept(1, 2, 3); // no problem
            arr[1] = new Exept(8, -2, 3); // devision by 0
            arr[2] = new Exept(3, 1, 3); // Wrong arguments
            for (int i = 0; i < 3; i++)
            {
                try
                {
                    arr[i].Func();
                    Console.WriteLine($"Result of equation[{i}]: {arr[i].Result}");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine($"Result of equation[{i}]: Devision by zero");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine($"Result of equation[{i}]: Wrong arguments");
                }
            }            
        }
    }
}
