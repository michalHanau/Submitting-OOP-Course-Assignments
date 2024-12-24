using System.Numerics;
using lesson4;
using lesson5;

internal class Program
{


    private static void Main(string[] args)
    {
        //exe1
        Fraction f1 = new Fraction(8, 12);
        Fraction f2 = new Fraction(3, 4);

        Fraction sum = f1 + f2;
        Fraction difference = f1 - f2;

        Console.WriteLine($"f1: {f1}"); 
        Console.WriteLine($"f2: {f2}"); 
        Console.WriteLine($"Sum: {sum}"); 
        Console.WriteLine($"Difference: {difference}");


        Fraction multiplicationResult = f1 * f2;
        Console.WriteLine($"{f1} * {f2} = {multiplicationResult}");

        Fraction divisionResult = f1 / f2;
        Console.WriteLine($"{f1} / {f2} = {divisionResult}");

        bool isSmaller = f1 < f2;
        bool isGreater = f1 > f2;
        bool isEqual = f1 == f2;
        bool isSmallerOrEqual = f1 <= f2;
        bool isGreaterOrEqual = f1 >= f2;

        Console.WriteLine($"{f1} < {f2}: {isSmaller}");
        Console.WriteLine($"{f1} > {f2}: {isGreater}");
        Console.WriteLine($"{f1} == {f2}: {isEqual}");
        Console.WriteLine($"{f1} <= {f2}: {isSmallerOrEqual}");
        Console.WriteLine($"{f1} >= {f2}: {isGreaterOrEqual}");

        //exe2
        List<Fraction> fractions = new List<Fraction>();
        for (int i = 1; i <= 12; i++)
        {
            fractions.Add(new Fraction(i, 12));
        }

        GenericOperationTable<Fraction> fractionTable = new GenericOperationTable<Fraction>(
            fractions,
            fractions,
            (x, y) => x + y // חיבור השברים
        );

        fractionTable.Print(); // הדפסת לוח החיבור
    }
}