
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        (string longestSubstring, int length) = FindLongestSubstring(input);
        Console.WriteLine("Longest Substring of string : "+longestSubstring);
        Console.WriteLine("Length of Longest Substring is : "+ length);
    }

    static (string, int) FindLongestSubstring(string str)
    {
        int maxLength = 0;
        int start = 0; 
        int[] lastSeen = new int[256]; 
        //Array.Fill(lastSeen, -1); 

        string longestSubstring = " ";

        for (int end = 0; end < str.Length; end++)
        {
            char currentChar = str[end];

            if (lastSeen[currentChar] >= start)
            {
                start = lastSeen[currentChar] + 1; 
            }

            lastSeen[currentChar] = end;

            int currentLength = end - start + 1;
            if (currentLength > maxLength)
            {
                maxLength = currentLength;
                longestSubstring = str.Substring(start, currentLength);
            }
        }

        return (longestSubstring, maxLength);
    }
}

