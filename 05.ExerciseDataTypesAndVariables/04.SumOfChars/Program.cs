// Read the number of characters
            int n = int.Parse(Console.ReadLine());

            // Initialize a variable to store the sum
            int sum = 0;

            // Read each character and add its ASCII code to the sum
            for (int i = 0; i < n; i++)
            {
                char character = char.Parse(Console.ReadLine());
                sum += (int)character;// sum = character + character;
            }

            // Print the sum
            Console.WriteLine($"The sum equals: {sum}");
        