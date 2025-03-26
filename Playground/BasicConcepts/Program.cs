using BasicConcepts;
using CSharpExercises.BasicConcepts;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wähle eine Übung");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                new AddressInformation().Run();
                break;
            case 2:
                new WThreeExc().Run();
                break;
            case 3:
                new SpecifiedOperationsResults().Run();
                break;
            case 4:
                new MultiplicationTable().Run();
                break;
            case 5:
                new CalculateAverage().Run();
                break;
            case 6:
                new RepeatNumbers().Run();
                break;
            case 7:
                new RectanglePattern().Run();
                break;
            case 8:
                new RemoveCharacterByIndex().Run();
                break;
            default:
                Console.WriteLine("Ungültige Auswahl");
                break;
        }
    }
}
