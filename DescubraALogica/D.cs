namespace DescubraALogica
{
    public static class D
    {
        public static void DiscoverTheLogic(int number)
        {
            Console.Write("D) ");
            for (int i = 0; i <= number * 2; i++)
            {
                if (i % 2 == 0)

                    Console.Write($"{i * i} ");
            }
            Console.WriteLine("\n");
        }
    }
}

