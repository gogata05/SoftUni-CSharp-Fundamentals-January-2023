string[] firstArray = Console.ReadLine().Split(); //[S, t o]
string[] secondArray = Console.ReadLine().Split();//[o, K, S]

for (int i = 0; i < secondArray.Length; i++)
{
    string currentElement = secondArray[i];//o

    if (firstArray.Contains(currentElement))
    {
        Console.Write(currentElement + " ");
    }
}


//for (int j = 0; j < firstArray.Length; j++)
//{
//    if (currentElement == firstArray[j])
//    {
//        Console.Write(currentElement + " ");
//    }

//}