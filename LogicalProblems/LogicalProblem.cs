namespace LogicalProblems;

public class LogicalProblem
{
    public int FibonacciCalculator(int inputNumber)
    {
        Console.WriteLine("Fibonacci series upto " + inputNumber + " numbers");
        int fibo1 = 1, fibo2 = 1, fibonacci = 1;
        for (int i = 1; i <= inputNumber; i++)
        {
            if (i == 1 || i == 2)
            {
                Console.Write(fibo1 + " ");
            }
            else
            {
                fibonacci = fibo1 + fibo2;
                fibo1 = fibo2;
                fibo2 = fibonacci;
                Console.Write(fibonacci + " ");
            }
        }
        return fibonacci;
    }
}