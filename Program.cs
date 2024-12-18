using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_7._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Getting the string to work with
            Console.WriteLine("Type your string here");
            string a = Console.ReadLine();
            string b = a.ToLower();

            //Define the vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            //Defining an output array to hold the vowels found in the input
            int xIndex = 0;
            char[] storage = new char[b.Length];

            char[] charArray = b.ToCharArray();
            foreach (char i in charArray)
            {
                if (Array.Exists(vowels, vowel => vowel == i)) //Lambda Expression
                {
                     storage[xIndex] = i;  //place 'i' into 'x'
                     xIndex++;     //Increment the position for 'x'
                }
            }

            Console.WriteLine(storage);
            Console.ReadKey();

        }

        


    }
}
