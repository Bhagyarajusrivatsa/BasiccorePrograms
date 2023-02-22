namespace BasiccorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor, quotient, remainder;

            Console.Write("Enter dividend: ");
            dividend = int.Parse(Console.ReadLine());

            Console.Write("Enter divisor: ");
            divisor = int.Parse(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("Quotient = {0}", quotient);
            Console.WriteLine("Remainder = {0}", remainder);
        }
    }
}
        
    
    
        
        
