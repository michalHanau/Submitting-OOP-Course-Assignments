using lesson4;
internal class Program
{
    private static void Main(string[] args)
    {
        //exe1
        Console.WriteLine("exe1:");
        //A
        int a = 10, b = 5;

        SortHelper.SortTwoA(ref a, ref b, (x, y) => x.CompareTo(y));

        Console.WriteLine($"a: {a}, b: {b}");


        //B
        int c = 15, d = 25;
        SortHelper.SortTwoB(ref c, ref d);

        Console.WriteLine($"a: {c}, b: {d}");

        //exe2
        Console.WriteLine("exe2:");

        List<double> rowValues = new List<double>();
        for (int i = 1; i <= 4; i++)
        {
            rowValues.Add(1.0 / i);
        }

        List<double> colValues = new List<double>();
        for (int i = 1; i <= 4; i++)
        {
            colValues.Add(1.0 / i);
        }

        // יצירת לוח פעולה לחיבור
        GenericOperationTable<double> additionTable = new GenericOperationTable<double>(
            rowValues, colValues, (x, y) => x + y
        );

        Console.WriteLine("Addition Table:");
        additionTable.Print();

        // יצירת לוח פעולה לכפל
        GenericOperationTable<double> multiplicationTable = new GenericOperationTable<double>(
            rowValues, colValues, (x, y) => x * y
        );

        Console.WriteLine("\nMultiplication Table:");
        multiplicationTable.Print();
    }
}