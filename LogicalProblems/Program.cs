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

    }
}
