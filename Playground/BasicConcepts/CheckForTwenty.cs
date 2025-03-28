namespace BasicConcepts
{
    public class CheckForTwenty
    {
        public void Run()
        {
            Console.WriteLine("Type in Number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type in Number");
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 20 || y == 20 || x + y == 20)
            {
                Console.WriteLine("Sum, x or y are 20.");
            }
            else
            {
                Console.WriteLine("Sum, x or y are not 20.");
            }
        }
    }
}