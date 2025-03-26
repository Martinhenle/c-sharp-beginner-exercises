namespace BasicConcepts
{
    public class RemoveCharacterByIndex
    {
        public void Run()
        {
            string x = "w3resource";
            Console.WriteLine(x.Remove(1, 1));

            //Swap character Positions
            string swapped = "";

            if (x.Length <= 1)
            {
                swapped = x;
            }
            else
            {
                char firstChar = x[0];
                char lastChar = x[x.Length - 1];

                string middle = x.Substring(1, x.Length - 2);

                swapped = lastChar + middle + firstChar;
            }

            Console.WriteLine(swapped);
        }

    }
}
