//int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
//        int maxCapacity = int.Parse(Console.ReadLine());

//        string command = Console.ReadLine();
//        while (command != "end")
//        {
//            if (command.StartsWith("Add"))
//            {
//                int passengersToAdd = int.Parse(command.Split()[1]);
//                wagons = wagons.Concat(new[] { passengersToAdd }).ToArray();//wagons.AddRange
//            }
//            else
//            {
//                int passengersToTransport = int.Parse(command);
//                for (int i = 0; i < wagons.Length; i++)
//                {
//                    int passengersInWagon = wagons[i];
//                    int emptySeats = maxCapacity - passengersInWagon;
//                    if (emptySeats >= passengersToTransport)
//                    {
//                        wagons[i] += passengersToTransport;
//                        break;
//                    }
//                }
//            }
//            command = Console.ReadLine();
//        }

//        // Print the final state of the train
//        Console.WriteLine(string.Join(" ", wagons));

List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
int maxCapacity = int.Parse(Console.ReadLine());

string command = Console.ReadLine();
while (command != "end")
{
    if (command.StartsWith("Add"))
    {
        int passengersToAdd = int.Parse(command.Split()[1]);
        
        wagons.Add(passengersToAdd);
        
    }
    else
    {
        int passengersToTransport = int.Parse(command);
        for (int i = 0; i < wagons.Count; i++)
        {
            int passengersInWagon = wagons[i];//
            int emptySeats = maxCapacity - passengersInWagon;
            if (emptySeats >= passengersToTransport)
            {
                wagons[i] += passengersToTransport;
                break;
            }
        }
    }
    command = Console.ReadLine();
}

Console.WriteLine(string.Join(" ", wagons));


