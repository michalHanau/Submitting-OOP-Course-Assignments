using lesson2;
using System;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Running MeasureObjectMemory...");
        answer.MeasureObjectMemory();

        Console.WriteLine("\nRunning MeasureHeapStringMemory...");
        answer.MeasureHeapStringMemory();

        Console.WriteLine("\nRunning CompareMemoryUsageForStrings...");
        answer.CompareMemoryUsageForStrings();

        Console.WriteLine("\nRunning TestGarbageCollectionGenerations...");
        answer.TestGarbageCollectionGenerations();
    }
}