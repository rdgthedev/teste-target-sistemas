using System;

namespace Testes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numberForGenerateSequence = 10;
            int numberPresentInTheSequence = 21;
            GenerateFibonacci.GenerateFibonacciSequence(numberForGenerateSequence);
            GenerateFibonacci.VerifyNumber(numberPresentInTheSequence);
        }
    }
}

