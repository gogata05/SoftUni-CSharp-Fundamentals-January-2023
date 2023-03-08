        List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();//1 2 2 4 2 2 2 9
                                                                                 // 0 1 2 3 4 5 6 7
                                                                                 //1 2 9
        int[] bombInfo = Console.ReadLine().Split().Select(int.Parse).ToArray();// 4 2
        int bombNumber = bombInfo[0];//4
        int bombPower = bombInfo[1];//2

      
        while (true)//
        {
            int bombIndex = numbers.IndexOf(bombNumber);//index of boomNumber = 3
            if (bombIndex == -1) break;//if exists
            int startIndex = Math.Max(0, bombIndex - bombPower);//1 = 0,3-2 //ako e -1//0+
            int count = Math.Min(numbers.Count - startIndex, 2 * bombPower + 1);//5//8-1, 2*2+1//why
                                                                                //numbers.Count - startIndex
                                                                                //4 5
            numbers.RemoveRange(startIndex, count);//1,5
        }//(bombIndex + bombPower,numbers.Count)5,4
        //

int sum = numbers.Sum();//12
        Console.WriteLine(sum);

    


