namespace TestMetalamaParameters;


public class Program
{
    public static void Main()
    {
        Console.WriteLine("Calling a first time.");
        Add<GenericType>(1, 1);
        Console.WriteLine("Calling a second time.");
        Add<GenericType>(1, 1);
        Console.WriteLine("Completed.");
    }

[Cache]
    public static int Add<T>(int a, int b, bool skipCache = false)
    {
        Console.WriteLine("Thinking...");

        return a + b;
    }
}

public class GenericType { }
