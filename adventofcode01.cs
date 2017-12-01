using System;

namespace AdventOfCode_AV
{
    public class AdventOfCode01
    {
        public static int Main(string[] args)
        {        
            if (args.Length < 1)
            {
                Console.WriteLine("Need some input. See http://adventofcode.com/2017/day/1");
                return -1;
            }

            string inputString = args[0]; // ignoring any args after the first
            int numDigits = inputString.Length;

            int sum1 = 0;
            int firstDigit = int.Parse(inputString.Substring(0,1));
            int currentDigit = firstDigit;
            for(int i=1; i<numDigits; i++)
            {
                int nextDigit = int.Parse(inputString.Substring(i, 1));
                if (currentDigit == nextDigit)
                    sum1 += currentDigit;
                currentDigit = nextDigit;
            }
            if (currentDigit == firstDigit)
                sum1 += currentDigit;

            Console.WriteLine("Given: {0}\n\nAnswer 1 is: {1}", inputString, sum1);

            int sum2 = 0;
            for(int i=0; i<numDigits/2; i++)
            {
                int leftDigit = int.Parse(inputString.Substring(i, 1));
                int rightDigit = int.Parse(inputString.Substring(i+numDigits/2, 1));
                if (leftDigit == rightDigit)
                    sum2 += leftDigit + rightDigit; // or leftDigit + leftDigit, or 2 * leftDigit
            }

            Console.WriteLine("\nAnswer 2 is: {0}", sum2);

            return 0;
        }
    }
}

