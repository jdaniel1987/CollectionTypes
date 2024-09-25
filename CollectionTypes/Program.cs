namespace CollectionTypes;

internal class Program
{
    static void Main(string[] args)
    {
        // Comment and uncomment to test each case
        var numbers = GetNumbersDeferredExecution();
        //var numbers = GetNumbersAsList();
        //var numbers = GetNumbersMaterialized();
        //var numbers = GetReadOnlyNumbers();

        Console.WriteLine("First iteration of random numbers:");
        Console.WriteLine(string.Join(" ", numbers));

        Console.WriteLine();
        Console.WriteLine("Second iteration of random numbers:");
        Console.WriteLine(string.Join(" ", numbers));
    }

    public static IEnumerable<int> GetNumbersDeferredExecution() =>
        // Deferred execution, DANGEROUS
        Enumerable.Range(1, 5).Select(_ => new Random().Next(1, 100));
    public static List<int> GetNumbersAsList() =>
        // Full list access
        Enumerable.Range(1, 5).Select(_ => new Random().Next(1, 100)).ToList();
    public static IEnumerable<int> GetNumbersMaterialized() =>
        // Materialized collection, flexibility
        Enumerable.Range(1, 5).Select(_ => new Random().Next(1, 100)).ToList();
    public static IReadOnlyCollection<int> GetReadOnlyNumbers() =>
        // Materialized collection, immutable
        Enumerable.Range(1, 5).Select(_ => new Random().Next(1, 100)).ToList();
}
