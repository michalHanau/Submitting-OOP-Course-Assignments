using lesson3;
internal class Program
{
    private static void Main(string[] args)
    {

        int[] numbers = { 1, 2, 3, 4, 5 };
        var sumCalculator = new SumCalculator();

        ArrayProcessor.ProcessArray(numbers, sumCalculator.AddToSum);

        int totalSum = sumCalculator.GetSum(); // Returns 15
        Console.WriteLine($"Total sum: {totalSum}");

        var maxCalculator = new MaxCalculator();

        ArrayProcessor.ProcessArray(numbers, maxCalculator.CalculatMax);

        int maxNumber = maxCalculator.GetMax();
        Console.WriteLine($"Max number: {maxNumber}");
    }
}