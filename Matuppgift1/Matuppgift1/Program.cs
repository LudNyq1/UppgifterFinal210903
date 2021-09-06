using System;

namespace Matuppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] mat = new string[3];
            int n = 0;
            while (n < 3)
            {
                Console.WriteLine("Vad är din favoritmaträtt " + (n + 1) + "?");
                mat[n] = Console.ReadLine();
                n++;
            }

            Console.WriteLine("Dina favoritmaträtter är: " + mat[0] + ", " + mat[1] + " och " + mat[2] + "\n");

            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(mat[i] + " har " + mat[i].Length + " bokstäver!\n");
                i++;
            }

            string longestWord = "";
            for (int x = 0; x <= (mat.Length - 1); x++)
            {
                if (mat[x].Length > longestWord.Length)
                {
                    longestWord = mat[x];
                }
                Console.WriteLine("Körd nmr " + x);
            }
            Console.WriteLine("Den längsta maträtten är: " + longestWord);


            Console.ReadLine();
        }
    }
}
