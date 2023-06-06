namespace LogicalProblems;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to logical problems...!!");
        LogicalProblem logicalProblem = new LogicalProblem();
        Console.WriteLine("Please enter number of fibonacci required");
        int inputNumber = Convert.ToInt32(Console.ReadLine());
        logicalProblem.FibonacciCalculator(inputNumber);
        Console.WriteLine();

        Console.WriteLine("Please enter number to find Perfect or not");
        int inputPerfectNumber = Convert.ToInt32(Console.ReadLine());
        logicalProblem.CheckPerfectNumber(inputPerfectNumber);
        Console.WriteLine();

        Console.WriteLine("Please enter number to check for prime number");
        int inputPrimeNumber = Convert.ToInt32(Console.ReadLine());
        logicalProblem.CheckPrimeNumber(inputPrimeNumber);
        Console.WriteLine();

        Console.WriteLine("Please enter number to get reverse number");
        int inputReverseNumber = Convert.ToInt32(Console.ReadLine());
        logicalProblem.GetReverseNumber(inputReverseNumber);
    }
}
