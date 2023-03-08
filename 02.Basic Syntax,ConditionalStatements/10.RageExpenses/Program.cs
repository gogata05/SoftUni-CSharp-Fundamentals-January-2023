int lostGamesNum = int.Parse(Console.ReadLine());
double headsetPrice = double.Parse(Console.ReadLine());
double mousePrice = double.Parse(Console.ReadLine());
double keyboardPrice = double.Parse(Console.ReadLine());
double displayPrice = double.Parse(Console.ReadLine());
double brokenHeadsetNum = lostGamesNum / 2;
double brokenMouseNum = lostGamesNum / 3;
double brokenKeyboardNum = lostGamesNum / 6;
double brokenDisplayNum = lostGamesNum / 12;
brokenHeadsetNum = Math.Floor(brokenHeadsetNum);
brokenMouseNum = Math.Floor(brokenMouseNum);
brokenKeyboardNum = Math.Floor(brokenKeyboardNum);
brokenDisplayNum = Math.Floor(brokenDisplayNum);
double totalBrokenHeadsetExpenses = 0;
double totalbrokenMouseExpenses = 0;
double totalbrokenKeyboardExpenses = 0;
double totalbrokenDisplayExpenses = 0;
double totalFinalPrice = 0; 

totalBrokenHeadsetExpenses = brokenHeadsetNum * headsetPrice;
totalbrokenMouseExpenses = brokenMouseNum * mousePrice;
totalbrokenKeyboardExpenses = brokenKeyboardNum * keyboardPrice;
totalbrokenDisplayExpenses = brokenDisplayNum * displayPrice;
totalFinalPrice = totalBrokenHeadsetExpenses + totalbrokenMouseExpenses + totalbrokenKeyboardExpenses + totalbrokenDisplayExpenses;

Console.WriteLine($"Rage expenses: {totalFinalPrice:f2} lv.");