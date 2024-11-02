using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alapok4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mekkora legyen a tömb?");
            int n= int.Parse(Console.ReadLine());
            int[] numberArray = new int[n];
            Random random = new Random();
            for (int i = 0; i < numberArray.Length; i++)
            {
                numberArray[i] = random.Next(2, 101); //2 és 100 között generál
                Console.Write($"{numberArray[i]}\t");
            }
            Console.WriteLine();
            int min = 0;
            for (int i = 1; i < numberArray.Length; i++)
            {
                if (numberArray[i] < numberArray[min]) min = i;
            }
            Console.WriteLine($"A legkisebb elem: {numberArray[min]}, az indexe pedig: {min}");
            int puffer;
            for (int i = 1; i < numberArray.Length; i++) {
                for (int j = 0; j < numberArray.Length; j++) { 
                    if (numberArray[j] > numberArray[i])
                    {
                        puffer = numberArray[j];
                        numberArray[j] = numberArray[i];
                        numberArray[i] = puffer;   
                    }
                }
            }
            foreach (int elem in numberArray) { 
                Console.Write($"{elem}\t");
            } Console.WriteLine();

        }
    }
}
