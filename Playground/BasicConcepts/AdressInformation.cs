namespace CSharpExercises.BasicConcepts
{
    public class AddressInformation
    {
        public void Run()
        {
            string name = "Martin Henle";
            string city = "Amberg";
            int houseNumber = 7;
            int zipCode = 92224;

            Console.WriteLine($"{name}, {city}, {houseNumber}, {zipCode}");
        }
    }
}
