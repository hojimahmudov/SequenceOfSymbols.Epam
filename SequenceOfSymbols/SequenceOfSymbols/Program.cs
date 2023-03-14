using System;

class MaxConsecutive
{
    static void Main(string[] args)
    {
        if (args.Length != 1)
        {
            Console.WriteLine("Usage: MaxConsecutive <sequence>");
            Environment.Exit(1);
        }

        string sequence = args[0];
        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] != sequence[i - 1])
            {
                currentCount++;
            }
            else
            {
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
                currentCount = 1;
            }
        }

        if (currentCount > maxCount)
        {
            maxCount = currentCount;
        }

        Console.WriteLine("Maximum number of unequal consecutive characters: " + maxCount);
    }
}
