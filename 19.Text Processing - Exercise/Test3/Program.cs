string[] link = Console.ReadLine().Split("\\");//C:\Internal\training-internal\Template.pptx
string word = link[link.Length-1];
string[] slipFinalWord =word.Split(".");
string word1 = slipFinalWord[0];
string word2 = slipFinalWord[1];
Console.WriteLine($"File name: {word1}");
Console.WriteLine($"File extension: {word2}");
 