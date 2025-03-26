namespace CSharpExercises.BasicConcepts;

public class SpecifiedOperationsResults
{
    public void Run()
    {
        //Operations
        Console.WriteLine(-1 + 4 * 6);
        Console.WriteLine((35 + 5) % 7);
        Console.WriteLine(14 + -4 * 6 / 11);
        Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);

        //Swap Numbers
        int a = 5;
        int b = 6;

        Console.WriteLine($"Numbers before swap a: {a} b: {b}");

        int c = b;
        b = a;
        a = c;


        Console.WriteLine($"Numbers after swap a: {a} b: {b}");

        //Multiply
        int d = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int f = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum: {d * e * f}");

        //Calculate different values
        Console.WriteLine($"SUM: {d + f}");
        Console.WriteLine($"SUB: {d - f}");
        Console.WriteLine($"DIV: {d / f}");
        Console.WriteLine($"Multiply: {d * f}");


    }
}
