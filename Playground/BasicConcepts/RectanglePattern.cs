namespace BasicConcepts
{
    public class RectanglePattern
    {
        public void Run()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int height = 5;

            for (int i = 0; i < height; i++)
            {
                Console.WriteLine("{0}{0}{0}{0}", number);
            }

        }
    }
}
