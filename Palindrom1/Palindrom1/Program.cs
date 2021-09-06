using System;

namespace Palindrom1
{
    class Program
    {
        static void Main(string[] args)
        {
            //HEEEEEEEEEEEEEEEEEEEEEEEj
            Console.WriteLine("Skriv in ett sk. palinrom (försök iallfall):");
            string palindromHel = Console.ReadLine();
            char[] palindromDelat = palindromHel.ToCharArray();
            char[] palindromOmvänd = new char[palindromDelat.Length];

            for (int i = 0; i < palindromDelat.Length; i++)
            {
                palindromOmvänd[i] = palindromDelat[(palindromDelat.Length - i - 1)];
            }

            string palindromOmvändString = new string(palindromOmvänd);
            Console.WriteLine(palindromOmvändString);
            Console.ReadLine();
        }
    }
}
