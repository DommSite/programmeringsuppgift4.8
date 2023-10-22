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

            for (int a = 0; a < kortsak.Length; a++)
            {
                char hitta = kortsak[a];

                for (int b = 0; b < sträng.Length; b++)
                {
                    char utsöktabokstav = sträng[b];
                    if (hitta == utsöktabokstav)
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
