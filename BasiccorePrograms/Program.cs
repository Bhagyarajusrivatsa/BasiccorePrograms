namespace BasiccorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a year (4 digits):");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year < 1000 || year > 9999)
            {
                Console.WriteLine("Please enter a 4-digit year.");
                return;
            }

            bool isLeapYear = false;

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        isLeapYear = true;
                    }
                }
                else
                {
                    isLeapYear = true;
                }
            }

            if (isLeapYear)
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
        
