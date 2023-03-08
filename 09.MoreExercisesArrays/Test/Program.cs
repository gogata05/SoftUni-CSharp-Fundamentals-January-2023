string input;
string output = "";

// Reading the input from the console
input = Console.ReadLine();

// Calculating the Ascii codes of each character in the string
foreach (char c in input)
{
    output += (int)c + " ";
}

// Writing the Ascii codes on the console
Console.WriteLine(output);