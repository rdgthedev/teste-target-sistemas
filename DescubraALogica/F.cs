using System.Text;

namespace DescubraALogica
{
    public class F
    {
        public static void DiscoverTheLogic()
        {
            List<string> sequence = new List<string>{
                "Zero", "Um", "Dois", "Três", "Quatro", "Cinco", "Seis", "Sete", "Oito", "Nove", "Dez",
                "Onze", "Doze", "Treze", "Catorze", "Quinze", "Dezesseis", "Dezessete", "Dezoito", "Dezenove",
                "Duzentos"
            };

            Console.Write("F) ");
            for (int i = 0; i <= sequence.Count - 1; i++)
            {
                var word = sequence.ToArray()[i].ToString().ToLower();

                if (word[0] == 'd')
                {
                    if (word.Equals("duzentos"))
                    {
                        Console.Write($"{i}0");
                        return;
                    }
                    else
                        Console.Write($"{i} ");
                }
            }
            Console.WriteLine("\n");
        }
    }
}

