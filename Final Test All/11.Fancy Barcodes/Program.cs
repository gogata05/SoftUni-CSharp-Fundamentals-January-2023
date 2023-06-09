using System;
using System.Text.RegularExpressions;
int n = int.Parse(Console.ReadLine());
int count = 0;
string num = "";
if (n>0)
{
    for (int i = 0; i < n; i++)
    {
        string input = Console.ReadLine();
        string pattern = @"[@]([#])+[A-Z][0-9A-Za-z]{4,}[A-Z][@]\1+";
        Regex regex = new Regex(pattern);
        Match match = regex.Match(input);
        if (match.Success)
        {

            char[] chars = match.Value.ToCharArray();
            foreach (char c in chars)//C = @
            {
                if (Char.IsDigit(c))//@
                {
                    count++;
                    num += c;
                }
            }
            if (count != 0)
            {
                Console.WriteLine($"Product group: {num}");
            }

            else if (count == 0)
            {
                Console.WriteLine($"Product group: 00");
            }
            count = 0;
            num = "";

        }
        else
        {
            Console.WriteLine($"Invalid barcode");
        }
    }

}
