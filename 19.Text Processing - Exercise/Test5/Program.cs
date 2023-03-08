using System.Text;

string num = Console.ReadLine();//23
int multiplier  = int.Parse(Console.ReadLine());//2
int reminder = 0;
var sb = new StringBuilder();
if (multiplier==0 || num == "0")
{
    Console.WriteLine(0);
    return;
}
for (int i = num.Length-1 ; i >= 0; i--)//2
{
    int currentDigit = int.Parse(num[i].ToString());
    int sum = multiplier * currentDigit + reminder;//9*9=81
    int type = sum % 10;//81%10=1
    reminder = sum / 10;//80/10=8
    sb.Insert(0, type);
}
if (reminder > 0)
{
    sb.Insert(0, reminder);
}

Console.WriteLine(sb.ToString());
