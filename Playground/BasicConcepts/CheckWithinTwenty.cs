namespace BasicConcepts
{
    public class CheckWithinTwenty
    {
        public void Run()
        {
            Console.WriteLine("Input an integer:");
            int x = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x - 100) <= 20 || Math.Abs(x - 200) <= 20)
            {
                Console.WriteLine("True");
            }
            else { Console.WriteLine("False"); }

        }
    }
}