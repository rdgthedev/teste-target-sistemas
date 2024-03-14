using System;

namespace StringReverse
{
    public class Program
    {
        static void Main(string[] args)
        {
            string word = "Target Sistemas";
            
            char[] wordConvert = new char[word.Length - 1];

            Console.Write($"\nString sem inverter: {word}\n");
            Console.Write("\nString invertida: ");
            
            for (int i = 1; i <= word.Length; i++)
            {
                wordConvert = word.ToCharArray();
                Console.Write($"{wordConvert[i - 1] = wordConvert[word.Length - i]}");
            }
        }
    }
}
