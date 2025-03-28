namespace BasicConcepts
{
    public class SumOfDigitsIntiger
    {
        public void Run()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (n != 0)
            {
                sum += n % 10; // Adding the last digit of 'n' to the 'sum' variable
                n /= 10; // Removing the last digit from 'n'
            }

            Console.WriteLine("SUM: " + sum);
        }
    }
}