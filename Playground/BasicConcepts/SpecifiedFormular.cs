namespace BasicConcepts
{
    public class SpecifiedFormular
    {
        public void Run()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int x = 5;
            int y = 6;
            int z = 7;


            Console.WriteLine($"{x}, {y} and {z} (x + y).z is {z}{z} and x.y + y.z is {y}{z}");

            //Print Age
            Console.WriteLine($"You look older then {a}");
        }
    }
}
