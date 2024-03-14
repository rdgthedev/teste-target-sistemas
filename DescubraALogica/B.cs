namespace DescubraALogica
{
    public static class B
    {
        public static void DiscoverTheLogic(int number)
        {
            int result = 1;
            Console.Write("B) ");
            for (int i = 0; i < number; i++)
            {
                result *= 2;
                Console.Write($"{result} ");
            }
            Console.WriteLine("\n");
        }
    }
}
