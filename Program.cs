namespace Assignment_5_2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.2.1
             * 
             * Given a string s consisting of words and spaces, return the length of 
             * the last word in the string. A word is a maximal substring consisting 
             * of non-space characters only.
             * 
             * Example 1:Input: s = "Hello World"
             * Output: 5
             * Explanation: The last word is "World" with length 5.
             * 
             * Example 2:
             * Input: s = " fly me to the moon "
             * Output: 4
             * Explanation: The last word is "moon" with length 4.
             */

            string s = "Hello World";

            Console.WriteLine( LastWordLength(s) );
        }

        static int LastWordLength(string S_)
        {
            // Return 0 if the string is empty or only has spaces in it
            if (string.IsNullOrWhiteSpace( S_)) return 0;

            // Remove any spaces from the end of the string
            S_ = S_.Trim();
            
            // Find the length of the last word
            for (int i = S_.Length; i > 0; i--)
            {
                if (S_[i - 1] == ' ')
                    return S_.Length - i;
            }
            return S_.Length;
        }
    }
}
