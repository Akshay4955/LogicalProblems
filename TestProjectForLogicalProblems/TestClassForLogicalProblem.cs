using LogicalProblems;

namespace TestProjectForLogicalProblems;

[TestClass]
public class TestClassForLogicalProblem
{
    LogicalProblem logicalProblem;

    [TestInitialize]
    public void Setup()
        {
            logicalProblem = new LogicalProblem();
        }

    [TestMethod]
    [DataRow(5, 5)]
    [DataRow(6, 8)]
    [DataRow(7, 13)]
    [DataRow(8, 21)]
    public void Fibonacci_WhenGivenNumberForFibonacci_ReturnsLastFibonacciNumber(int number, int expected)
    {
        int result = logicalProblem.FibonacciCalculator(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, true)]
    [DataRow(7, false)]
    [DataRow(28, true)]
    [DataRow(29, false)]
    [DataRow(30, false)]
    public void PerfectNumber_WhenNumberIsGiven_ReturnsTrueAndFalseForPerfectNumber(int number, bool expected) 
    {
        bool result = logicalProblem.CheckPerfectNumber(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(6, false)]
    [DataRow(7, true)]
    [DataRow(8, false)]
    [DataRow(11, true)]
    [DataRow(15, false)]
    [DataRow(17, true)]
    public void PrimeNumber_WhenNumberIsGiven_ReturnsTrueAndFalseForPrimeNumber(int number, bool expected)
    {
        bool result = logicalProblem.CheckPrimeNumber(number);

        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow(1234, 4321)]
    [DataRow(456383, 383654)]
    [DataRow(73573, 37537)]
    [DataRow(765675, 576567)]
    public void ReverseNumber_WhenNumberIsGiven_ReturnsReverseNumber(int number,  int expected)
    {
        int result = logicalProblem.GetReverseNumber(number);

        Assert.AreEqual(expected, result);
    }
}