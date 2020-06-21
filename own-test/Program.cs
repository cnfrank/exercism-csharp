using System;

namespace own_test
{
    class Program
    {
            public static bool IsIsogram(string word)
            {
                // throw new NotImplementedException("You need to implement this function.");
                string wordLower = word.Replace(" ","").ToLower(); // lowercase the input word

                int stringLength = word.Length;

                char[] charArray = wordLower.ToCharArray();

                Array.Sort(charArray); // 

                for (int i = 0; i < stringLength - 1; i++)
                {
                    if (charArray[i] == charArray[i + 1])

                        return false;

                }
                return true;

            }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
           
            Console.WriteLine(IsIsogram("Emily Jung Schwartzkopf"));
        }
    }
}
