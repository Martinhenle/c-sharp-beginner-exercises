namespace BasicConcepts
{
    public class RepeatNumbers
    {
        public void Run()
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int i = 0;

            while (i < 2)
            {
                Console.WriteLine($"{number} {number} {number} {number}");
                Console.WriteLine($"{number}{number}{number}{number}");
                i++;
            }

        }
    }
}
