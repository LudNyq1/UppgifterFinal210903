using System;

namespace FavviCitat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ditt favorit citat (Minst fem ord):\n");
            string citatHel = Console.ReadLine();
            string[] citatUppdelat = citatHel.Split(' ', '\n');
            if (citatUppdelat.Length >= 5)
            {
                Console.WriteLine("Ditt citat var \"" + citatHel
                    + "\"\n\t Vilket innehåller " + citatUppdelat.Length + " ord!\n");

                foreach (string i in citatUppdelat)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Citatet måste vara minst 5 ord!");
            }

            Console.ReadLine();
        }
    }
}
