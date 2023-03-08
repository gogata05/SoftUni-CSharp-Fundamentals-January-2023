using System;
using System.Linq;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = new string[n];

            for (int i = 0; i < n; i++)
            {
                names[i] = Console.ReadLine();
            }

            int[] encrypted = EncryptStrings(names);
            Array.Sort(encrypted);

            Console.WriteLine(string.Join("\n", encrypted));
        }

        static int[] EncryptStrings(string[] names)
        {
            int[] result = new int[names.Length];

            for (int i = 0; i < names.Length; i++)
            {
                int sum = 0;
                int length = names[i].Length;

                foreach (char c in names[i])
                {
                    if (IsVowel(c))
                    {
                        sum += c * length;
                    }
                    else
                    {
                        sum += (int)c / length;
                    }
                }

                result[i] = sum;
            }

            return result;
        }

        static bool IsVowel(char c)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            return vowels.Contains(c);
        }
    }
}
