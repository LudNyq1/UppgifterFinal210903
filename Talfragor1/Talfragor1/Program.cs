using System;

namespace Talfragor1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int rep = Convert.ToInt32(Console.ReadLine()); //Rep = Repetition

            int[] tal = new int[rep]; //Array för talen, array får antalet "rep" platser
            for (int i = 0; i < rep; i++) //För varje plats i arrayen matas in ett tal
            {
                Console.WriteLine("Skriv in ett tal(" + (i + 1) + ")");
                tal[i] = Convert.ToInt32(Console.ReadLine());
            }

            int summa = 0;
            foreach (int i in tal) //Räknar ut summan av angivna talen
            {
                summa += i;
            }
            Console.WriteLine("Summan är:" + summa);

            Array.Sort(tal);
            int min = tal[0];
            int max = tal[rep - 1];

            /*for(int i = 0; i < tal.Length - 1; i++)
            {
                if(min < tal[i+1])
                {
                    min = tal[i];
                }
                if(max > tal[i+1])
                {
                    max = tal[i];
                }
            }*/
            Console.WriteLine("Max: " + max + "\nMin: " + min);
            double median = 0.0;

            if (rep % 2 == 0)
            //Exempel tal[] = {1, 2, 3, 4}
            {
                double even1 = tal[(rep - 1) / 2 + 1]; // Plats 2,5 finns inte, programmet avrundar neråt till plats två automatiskt.
                double even2 = tal[(rep - 1) / 2];
                median = (even1 + even2) / 2.0;
            }
            else //Exempel tal[] = {1, 2, 3}
            {
                median = tal[(rep - 1) / 2]; //Plats 1,5 finns inte drf avrundas ner till [1] vilket är medianen för ojämn array.
            }
            Console.WriteLine("Medianen: " + median);
        }
    }
}
