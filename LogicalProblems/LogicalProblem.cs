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

    public bool CheckPerfectNumber(int inputNumber)
    {
        int divisorsSum = 0;
        for (int i = 1; i <= inputNumber / 2; i++)
        {
            if (inputNumber % i == 0)
            {
                divisorsSum += i;
            }
        }
        if (divisorsSum == inputNumber)
        {
            Console.WriteLine(inputNumber + " is a perfect number");
            return true;
        }
        else
        {
            Console.WriteLine(inputNumber + " is not a perfect number");
            return false;
        }
    }

    public bool CheckPrimeNumber(int inputNumber)
    {
        bool status = true;
        for (int i = 2; i <= inputNumber / 2; i++)
        {
            if (inputNumber % i == 0)
            {
                status = false;
                break;
            }

        }
        if (status == true)
        {
            Console.WriteLine(inputNumber + " is a prime number");
            return true;
        }
        else
        {
            Console.WriteLine(inputNumber + " is not a prime number");
            return false;
        }
    }

    public int GetReverseNumber(int inputNumber)
    {
        int reverseNumber = 0;
        while (inputNumber != 0)
        {
            int remainder = inputNumber % 10;
            reverseNumber = reverseNumber * 10 + remainder;
            inputNumber = inputNumber / 10;
        }
        Console.WriteLine("Reverse number is " + reverseNumber);
        return reverseNumber;
    }
}