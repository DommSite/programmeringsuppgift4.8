using System;

namespace inlämningsuppgift4_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in en sträng");
            string sträng = Console.ReadLine();
            Console.WriteLine("Skriv in exakt 2 tecken");
            string kortsak = Console.ReadLine();

            string hittade = "";

            for (int i = 0; i < kortsak.Length; i++)
            {
                char hitta = kortsak[i];

                for (int j = 0; j < sträng.Length; j++)
                {
                    char leta = sträng[j];
                    if (hitta == leta)
                    {
                        hittade = hittade + hitta;
                        break;
                    }
                }
            }
            if (hittade == kortsak)
            {
                Console.WriteLine("Bokstäverna är någonstans i strängen");
            }
            else
            {
                Console.WriteLine("Bokstäverna är inte med i strängen");
            }
            Console.ReadKey();
        }
    }
}
