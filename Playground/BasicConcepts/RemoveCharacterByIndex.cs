namespace BasicConcepts
{
    public class RemoveCharacterByIndex
    {
        public void Run()
        {
            //Remove Char at specified position
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

            // Add First Character to Front and Back
            char xFirstChar = x[0];
            char xLastChar = x[x.Length - 1];

            string xFinal = x + xFirstChar;

            Console.WriteLine($"xfirstChar = {xFirstChar} | xLastChar = {xLastChar} | xFinal {xFinal}");
        }

    }
}
