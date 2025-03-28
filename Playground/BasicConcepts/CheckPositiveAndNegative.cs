namespace BasicConcepts
{
    public class CheckPositiveAndNegative
    {
        private int first;
        private int second;

        public void Run()
        {
            Console.WriteLine("Input First number");
            this.first = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input Second number");
            this.second = Convert.ToInt32(Console.ReadLine());

            // Rest des Codes bleibt unverändert, aber verwendet this.first und this.second

            int res1 = Run2();
            int res2 = Run3();
            Console.WriteLine($"Ergebnis von Run2: {res1}");
            Console.WriteLine($"Ergebnis von Run3: {res2}");


        }

        public int Run2()
        {
            return first == second ? (first + second) * 3 : first + second;
        }

        //Write a C# program to get the absolute value of the difference between two given numbers. Return double the absolute value of the difference if the first number is greater than the second number.

        public int Run3()
        {
            int dif = Math.Abs(first - second);
            return first > second ? dif * 2 : dif;
        }
    }
}
