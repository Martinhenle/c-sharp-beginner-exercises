namespace BasicConcepts
{
    public class PrintOddNumbers
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
