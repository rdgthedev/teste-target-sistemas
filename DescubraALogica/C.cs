namespace DescubraALogica
{
    public static class C
    {
        public static void DiscoverTheLogic(int number)
        {
            Console.Write("C) ");
            for (int i = 1; i <= number + 1; i++)
            {
                int result = (i - 1) * (i - 1);
                Console.Write($"{result} ");
            }
            Console.WriteLine("\n");
        }
    }
}