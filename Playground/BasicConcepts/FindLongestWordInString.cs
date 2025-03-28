namespace BasicConcepts
{
    public class FindLongestWordInString
    {
        public void Run()
        {
            string s = "Heute ist ein wunderschöner Tag";
            // Splitting the string into words based on spaces and storing them in an array
            string[] xArray = s.Split(' ');

            string maxWord = ""; // Initializing an empty string to store the word with the maximum length
            int ctr = 0; // Initializing a counter variable to keep track of the maximum length

            foreach (string x in xArray)
            {
                // Checking if the length of the current word is greater than the stored maximum length
                if (x.Length > ctr)
                {
                    maxWord = x; // If the current word's length is greater, update the 'word' variable
                    ctr = x.Length; // Update the maximum length counter
                }
            }

            Console.WriteLine(maxWord);
        }
    }
}
