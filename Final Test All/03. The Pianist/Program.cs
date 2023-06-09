int n = int.Parse(Console.ReadLine());//3 
Dictionary<string, string> dictionary = new Dictionary<string, string>();
//Fur Elise|Beethoven|A Minor 
//Moonlight Sonata|Beethoven|C# Minor 
//Clair de Lune|Debussy|C# Minor 
for (int i = 0; i < n; i++)
{
    string intput = Console.ReadLine();
    string[] inputArray = intput.Split("|");
    string pieceName = inputArray[0];//Fur Elise
    string composerAndKey = $"{inputArray[1]}:{inputArray[2]}";//Beethoven:A Minor
    dictionary.Add(pieceName, composerAndKey);
    //Fur Elise//Beethoven:A Minor
    //Moonlight Sonata//Beethoven:C# Minor 
    //Clair de Lune//Debussy:C# Minor 
}
string command = Console.ReadLine();//Add|Sonata No.2|Chopin|B Minor 
//Add|Sonata No.2|Chopin|B Minor 
//Add|Hungarian Rhapsody No.2|Liszt|C# Minor 
//Add|Fur Elise|Beethoven|C# Minor 
//Remove|Clair de Lune 
//ChangeKey|Moonlight Sonata|C# Major 
//Stop 
while (command != "Stop")//Add|Sonata No.2|Chopin|B Minor 
{
    string[] commandArray = command.Split("|");
    string act = commandArray[0];//add
    if (act == "Add")
    {
        string pieceToAdd = commandArray[1];//Sonata No.2
        string composerName = commandArray[2];//Chopin
        string key = commandArray[3];//B Minor 
        string composerAndKeyNew = $"{commandArray[2]}:{commandArray[3]}";//Chopin:B Minor 
        if (!dictionary.ContainsKey(pieceToAdd))
        {
            dictionary.Add(pieceToAdd, composerAndKeyNew);
            Console.WriteLine($"{pieceToAdd} by {composerName} in {key} added to the collection!");//Sonata No.2//Chopin//B Minor
        }
        else
        {
            Console.WriteLine($"{pieceToAdd} is already in the collection!");//Sonata No.2
        }
    }
    else if (act == "Remove")//Remove|Clair de Lune 
    {
        string pieceToRemove = commandArray[1];//Clair de Lune 
        if (dictionary.ContainsKey(pieceToRemove))
        {
            dictionary.Remove(pieceToRemove);//Clair de Lune 
            Console.WriteLine($"Successfully removed {pieceToRemove}!");
        }
        else
        {
            Console.WriteLine($"Invalid operation! {pieceToRemove} does not exist in the collection.");//Clair de Lune 
        }
    }
    else if (act == "ChangeKey")//ChangeKey|Moonlight Sonata|C# Major 
    {
        //Moonlight Sonata   Beethoven:C# Minor
        //Moonlight Sonata C# Major
        string pieceChangeKey = commandArray[1];//Moonlight Sonata
        string keyToReplace = commandArray[2];//C# Major 
        if (dictionary.ContainsKey(pieceChangeKey))//Moonlight Sonata
        {
            string[] composerAndKeyArray = dictionary[pieceChangeKey].Split(":");//.Value?//Beethoven:C# Minor
            string composer = composerAndKeyArray[0];//Beethoven
            string key = composerAndKeyArray[1];//C# Minor
            Console.WriteLine($"Changed the key of {pieceChangeKey} to {keyToReplace}!");
            key = keyToReplace;//C# Major 
            string composerAndKeyNew = $"{composer}:{key}";//Beethoven:C# Major 
            dictionary[pieceChangeKey] = composerAndKeyNew;
        }
        else
        {
            Console.WriteLine($"Invalid operation! {pieceChangeKey} does not exist in the collection.");
        }
    }
    command = Console.ReadLine();
}
foreach (var item in dictionary)
{
    string piece = item.Key;//value?
    string composerAndKey = item.Value;
    string[] composerAndKeyArray = composerAndKey.Split(":");
    string composer = composerAndKeyArray[0];
    string key = composerAndKeyArray[1];
    //Console.WriteLine(string.Join(" ", item));
    Console.WriteLine($"{piece} -> Composer: {composer}, Key: {key}");
}