namespace DescubraALogica
{
    public static class A
    {
        public static void DiscoverTheLogic(int number)
        {
            int result = 1;
            Console.Write("A) ");
            for (int i = 0; i < number; i++)
            {
                Console.Write($"{result} ");
                result += 2;
            }
            Console.WriteLine("\n");
        }
    }
}