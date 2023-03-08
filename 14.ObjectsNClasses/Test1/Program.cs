//Welcome to SoftUni and have fun learning programming

string[] wordsArray = Console.ReadLine().Split();
for (int i = 0; i < wordsArray.Length; i++)
{
    Random random = new Random();
    int randomIndex = random.Next(0,wordsArray.Length);
    string currentWord = wordsArray[i];//safe 1st word
    string randomWord = wordsArray[randomIndex];
    wordsArray[i] = wordsArray[randomIndex];
    wordsArray[randomIndex] = currentWord;
}

Console.WriteLine(string.Join(Environment.NewLine, wordsArray));