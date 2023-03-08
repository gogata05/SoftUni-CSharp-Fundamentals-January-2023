//Welcome to SoftUni and have fun learning programming
//0 1 2 3 4 5 6 7
//0 -> words.Lenght - 1

string[] wordsArray = Console.ReadLine().Split();

for (int i = 0; i < wordsArray.Length; i++)//0 7
{
    Random random = new Random();
    int randomIndexNum = random.Next(0,wordsArray.Length);//0...word>length//we generate random num
    string currentWord = wordsArray[i];//Welcome//we create currentWord of i
    string swapWord = wordsArray[randomIndexNum];//fun...
    wordsArray[i] = swapWord;//Welcome = to
    wordsArray[randomIndexNum] = currentWord;//to = welcome
}

Console.WriteLine(string.Join(Environment.NewLine, wordsArray));
