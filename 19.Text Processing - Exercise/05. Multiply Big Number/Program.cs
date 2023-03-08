using System.Text;
//23*2
string input = Console.ReadLine(); // 23
int multiplier = int.Parse(Console.ReadLine()); // 2
var sb = new StringBuilder(); 
int reminder = 0;
if (multiplier == 0 || input == "0")
{
    Console.WriteLine(0);
    return;
}
for (int i = input.Length - 1; i >= 0; i--) 
{
    int currentDigit = int.Parse(input[i].ToString()); // 3
    int sum = currentDigit * multiplier + reminder;//3*2+0
    int type = sum % 10; //6%10=6
    reminder = sum / 10;//0%10=0
    sb.Insert(0, type);
}
if (reminder > 0)
{
    sb.Insert(0, reminder);
}
Console.WriteLine(sb.ToString());