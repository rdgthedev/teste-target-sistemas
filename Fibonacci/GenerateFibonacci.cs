using System.Reflection.Metadata;

namespace Testes
{
    public static class GenerateFibonacci
    {
        private const int _checkNumber = 1;
        private static int[] Sequence { get; set; }

        public static void GenerateFibonacciSequence(int number)
        {
            Sequence = new int[number];

            for (int i = 0; i < number; i++)
            {
                if (i + 1 != number)
                    Console.Write($"{Fibonacci(i)}, ");
                else
                    Console.Write($"{Fibonacci(i)}. ");

                Sequence[i] = Fibonacci(i);
            }
        }

        private static int Fibonacci(int number)
        {
            if (number == 0)
                return 0;
            if (number == 1)
                return 1;
            if (number == 2)
                return 1;

            return Fibonacci(number - 1) + Fibonacci(number - 2);
        }

        private static bool GetNumberInSequenceFibonacci(int value)
        {
            foreach (var number in Sequence)
            {
                if (number == value)
                    return true;
            }

            return false;
        }

        public static void VerifyNumber(int value)
        {
            bool haveNumber = GetNumberInSequenceFibonacci(value);

            if (haveNumber)
            {
                Console.WriteLine($"\n\nO número {value} pertence a sequência de Fibonacci!");
                return;
            }

            Console.WriteLine($"\n\nO número {value} não pertence a sequência de Fibonacci!");
        }
    }
}