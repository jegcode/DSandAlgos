using System;

namespace UniqueCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = IsUnique("Helo Werld!");
            Console.WriteLine(result);


        }

        private static bool IsUnique(string str)
        {
            char ch; 

            if (str.Length > 128)
                return false;

            for (int i = 0; i < str.Length; i++)
            {
                ch = str[i];
                if(str.IndexOf(ch, i + 1) > -1)
                {
                    return false;
                }
            }

            return true; 
        }
    }
}
