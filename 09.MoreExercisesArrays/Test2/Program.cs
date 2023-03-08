// Read the number of strings
            int n = int.Parse(Console.ReadLine());

            // Create an array to store the encrypted strings
            int[] encryptedStrings = new int[n];

            // Read the strings and encrypt them
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int sum = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    char c = input[j];
                    int code = (int)c;
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                        c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        sum += code * input.Length;
                    }
                    else
                    {
                        sum += code / input.Length;
                    }
                }
                encryptedStrings[i] = sum;
            }

            // Sort the encrypted strings in ascending order
            Array.Sort(encryptedStrings);

            // Print the encrypted strings
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(encryptedStrings[i]);
            }
        
    

