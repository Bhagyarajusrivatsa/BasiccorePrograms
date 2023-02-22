namespace BasiccorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            {
                Console.WriteLine("Enter the number of times to flip the coin:");
                int numFlips = Convert.ToInt32(Console.ReadLine());

                if (numFlips <= 0)
                {
                    Console.WriteLine("Please enter a positive integer.");
                    return;
                }

                int numHeads = 0;
                int numTails = 0;
                Random rnd = new Random();

                for (int i = 0; i < numFlips; i++)
                {
                    int flip = rnd.Next(0, 2);
                    if (flip == 0)
                    {
                        numHeads++;
                    }
                    else
                    {
                        numTails++;
                    }
                }

                double percentageHeads = ((double)numHeads / numFlips) * 100;
                double percentageTails = ((double)numTails / numFlips) * 100;

                Console.WriteLine("Percentage of heads: " + percentageHeads.ToString("0.00") + "%");
                Console.WriteLine("Percentage of tails: " + percentageTails.ToString("0.00") + "%");
            }
        }
    }
}
