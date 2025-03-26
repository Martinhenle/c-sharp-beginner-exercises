namespace BasicConcepts
{
    public class CalculateAverage
    {
        public void Run()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Average{(a + b + c + d) / 4}");
        }
    }
}
