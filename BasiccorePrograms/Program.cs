namespace BasiccorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 10;
            int temp;

            Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2);
        }
    }
}
    
        
    
    
        
        
