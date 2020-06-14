using System;

/* This program asks the user to input 2 words, and the program will check if the 2 words are anagrams of each other. */

namespace IsAnagram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first word: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Input a second word to see if it's an anagram of the first: ");
            string str2 = Console.ReadLine();
            Console.WriteLine(Anagram(str1, str2));
        }

        //This function checks if the 2 inputted words are anagrams
        public static bool Anagram(string s, string t)
        {
            if (t.Length > s.Length)
            {
                return false;
            }
            foreach(char a in s)
            {
                int i = 0;
                foreach(char b in t)
                {
                    if(a == b)
                    {
                        t = Slice(b, t);
                        i++;
                        break;
                    }
                }
                if (i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        //Will remove a certain char, let, from a string
        public static string Slice(char let, string str)
        {
            int charPos = str.IndexOf(let);
            if (charPos == 0)
            {
                return str.Substring(1);
            }
            else if (charPos == str.Length-1)
            {
                return str.Substring(0, str.Length-1);
            }
            else
            {
                string subStr = str.Substring(0,charPos) + str.Substring(charPos+1);
                return subStr;
            }
            
        }
    }
}
