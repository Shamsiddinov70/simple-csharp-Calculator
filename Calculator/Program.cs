using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator\n");
            float n1;
            float n2;
            Console.WriteLine("Son kiriting\n");

            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Yana bir Son kiriting\n");

            n2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("\ta - harfi ayirish\n");
            Console.WriteLine("\tb - harfi qo'shish\n");
            Console.WriteLine("\tc - harfi bo'lish\n");
            Console.WriteLine("\td - harfi ko'paytirish\n");
           /* Console.WriteLine("\te - harfi darajaga chiqarish\n");*/

            switch (Console.ReadLine())
            { 
                case "a":
                    Console.WriteLine($"Answer is :  {n1} - {n2} = {n1 - n2}");
                    break;
                case "b":
                    Console.WriteLine($"Answer is :  {n1} + {n2} = {n1 + n2}");
                    break;
                case "c":
                    while (n2 == 0)
                    {
                        Console.WriteLine("0 bo'lmagan son kiriting");
                        n2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Answer is :  {n1} / {n2} = {n1 / n2}");
                    break;
                case "d":
                    Console.WriteLine($"Answer is : {n1} * {n2} = {n1 * n2}");
                    break;
                /*case "e":
                    Console.WriteLine($"Answer is : {n1} ^ {n2} = {Math.Pow(n1, n2)}");
                    break;*/
            }
        }
    }
}