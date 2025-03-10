using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        //StringConversion();
        //StringAsArray();
        //EscapeString();
        //AppendingStrings();
        //InterpolationAndLiteral();
        //StringBuilderDemo();
        //Arrays();
        //PadAndTrim();
        //SearchingStrings();
        //OrderingStrings();
        //TestingEquality();
        Substring();
    }

    private static void StringConversion()
    {
        string testString = "tHis IS thE FBI CallIng";
        TextInfo currentTextInfo = CultureInfo.CurrentCulture.TextInfo;
        TextInfo germanTextInfo = new CultureInfo("de-DE", false).TextInfo;
        string result;

        result = testString.ToLower();
        Console.WriteLine(result);

        result = testString.ToUpper();
        Console.WriteLine(result);

        result = currentTextInfo.ToTitleCase(testString);
        Console.WriteLine(result);

        result = germanTextInfo.ToTitleCase(testString);
        Console.WriteLine(result);
    }

    private static void StringAsArray()
    {
        string testString = "Martin";

        for (int i = 0; i < testString.Length; i++)
        {
            Console.WriteLine(testString[i]);
        }
    }

    private static void EscapeString()
    {
        string results;

        results = "This is my \"test\" solution";
        Console.WriteLine(results);

        results = "C:\\temp\\Test.txt";
        Console.WriteLine(results);

        //String Literals
        results = @"C:\temp\Test.txt";
        Console.WriteLine(results);
    }

    private static void AppendingStrings()
    {
        string firstName = "Martin";
        string lastName = "Henle";
        string results;

        results = firstName + ", my name is " + firstName + " " + lastName;
        Console.WriteLine(results);

        results = string.Format("{0}, my name is {0} {1}", firstName, lastName);
        Console.WriteLine(results);

        //String Interpolation
        results = $"{firstName}, my name is {firstName} {lastName}";
        Console.WriteLine(results);
    }

    private static void InterpolationAndLiteral()
    {
        string testString = "Martin Henle";
        string results = $@"C:\Demo\{testString}\{"\""}Test{"\""}.txt";
        Console.WriteLine(results);
    }

    private static void StringBuilderDemo()
    {
        Stopwatch regularStopwatch = new Stopwatch();
        regularStopwatch.Start();

        string test = "";

        for (int i = 0; i < 100000; i++)
        {
            test += i;
        }

        regularStopwatch.Stop();
        Console.WriteLine($"Regular Stopwatch : {regularStopwatch.ElapsedMilliseconds} ms");
    }

    private static void Arrays()
    {
        int[] ages = new int[] { 1, 2, 3, 4, 5, 6, 7 };
        string results;

        results = String.Concat(ages);
        Console.WriteLine(results);

        results = String.Join(",", ages);
        Console.WriteLine(results);

        Console.WriteLine();

        string testString = "Martin,Johann,Jasmin,Dana,Marco,Marina";
        string[] resultsArray = testString.Split(',');

        Array.ForEach(resultsArray, x => Console.WriteLine(x));

        testString = "Martin, Johann, Jasmin, Dana, Marco, Marina";
        resultsArray = testString.Split(", ");

        Array.ForEach(resultsArray, x => Console.WriteLine(x));
    }

    private static void PadAndTrim()
    {
        string testString = "     Hello World        ";
        string results;

        results = testString.TrimStart();
        Console.WriteLine($"'{results}'");

        results = testString.TrimEnd();
        Console.WriteLine($"'{results}'");

        results = testString.Trim();
        Console.WriteLine($"'{results}'");

        testString = "1.15";

        results = testString.PadLeft(10, '0');
        Console.WriteLine(results);

        results = testString.PadRight(10, '0');
        Console.WriteLine(results);
    }

    private static void SearchingStrings()
    {
        string testString = "This is a test of the search. Lets see how its testin works out.";
        bool resultsBoolean;
        int resultsInt;

        // Is case sensitive
        resultsBoolean = testString.StartsWith("This is");
        Console.WriteLine(resultsBoolean);

        resultsBoolean = testString.EndsWith("works out.");
        Console.WriteLine(resultsBoolean);

        resultsBoolean = testString.Contains("search");
        Console.WriteLine(resultsBoolean);

        resultsInt = testString.IndexOf("test");
        Console.WriteLine(resultsInt);

        resultsInt = testString.IndexOf("test", 11);
        Console.WriteLine(resultsInt);

        resultsInt = testString.LastIndexOf("test", 50);
        Console.WriteLine(resultsInt);
    }

    private static void OrderingStrings()
    {
        CompareToHelper("Martin", "Jasmin");
        CompareToHelper("Martin", null);
        CompareToHelper("David", "Johann");
        CompareToHelper("Johann", "Johann");
        CompareToHelper("Johann", "Johannes");

        Console.WriteLine();

        CompareHelper("Martin", "Jasmin");
        CompareHelper("Martin", null);
        CompareHelper("David", "Johann");
        CompareHelper("Johann", "Johann");
        CompareToHelper("Johann", "Johannes");
        CompareHelper(null, null);
    }

    private static void CompareToHelper(string testA, string? testB)
    {
        int resultsInt = testA.CompareTo(testB);
        switch (resultsInt)
        {
            case > 0:
                Console.WriteLine($"CompareTo: {testB ?? "null"} comes before {testA}");
                break;
            case < 0:
                Console.WriteLine($"CompareTo: {testA} comes before {testB}");
                break;
            case 0:
                Console.WriteLine($"CompareTo: {testA} is the same as {testB}");
                break;
        }
    }

    private static void CompareHelper(string? testA, string? testB)
    {
        int resultsInt = String.Compare(testA, testB);
        switch (resultsInt)
        {
            case > 0:
                Console.WriteLine($"Compare: {testB ?? "null"} comes before {testA}");
                break;
            case < 0:
                Console.WriteLine($"Compare: {testA ?? "null"} comes before {testB}");
                break;
            case 0:
                Console.WriteLine($"Compare: {testA ?? "null"} is the same as {testB ?? null}");
                break;
        }
    }

    private static void TestingEquality()
    {
        EqualityHelper("Bob", "Mary");
        EqualityHelper(null, "");
        EqualityHelper("", " ");
        EqualityHelper("Bob", "bob");

    }

    private static void EqualityHelper(string? testA, string? testB)
    {
        bool resultBoolean;

        resultBoolean = String.Equals(testA, testB);
        if (resultBoolean)
        {
            Console.WriteLine($"Equals: '{testA ?? "null"}' equals {testB ?? "null"}");
        }
        else
        {
            Console.WriteLine($"Equals: '{testA ?? "null"}' does not equal {testB ?? "null"}");
        }

        resultBoolean = String.Equals(testA, testB, StringComparison.InvariantCultureIgnoreCase);
        if (resultBoolean)
        {
            Console.WriteLine($"Equals: '{testA ?? "null"}' equals {testB ?? "null"}");
        }
        else
        {
            Console.WriteLine($"Equals: '{testA ?? "null"}' does not equal {testB ?? "null"}");
        }
    }

    private static void Substring()
    {
        string testString = "LovexMyself";
        string results;

        results = testString.Substring(5); // Start at this position
        Console.WriteLine(results); // (5,4) start at position 5 and go on 4 characters
    }
}

