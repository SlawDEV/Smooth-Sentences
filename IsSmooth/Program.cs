/*
The function is checking if the given sentence is smooth.

A smooth sentence is one where the last letter of each word is identical to the first letter
the following word (and not case sensitive, so "A" would be the same as "a").


 */

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsSmooth("Marta appreciated deep perpendicular right trapezoids"));
            Console.WriteLine(IsSmooth("Someone is outside the doorway"));
            Console.WriteLine(IsSmooth("She eats super Righteously"));
            Console.WriteLine(IsSmooth("Mark knows       some electricians"));



            Console.ReadKey();
        }

        static bool IsSmooth(string sentence)
        {
            int j;
            char char1;
            char char2;
            for(int i=0; i<sentence.Length; i++)
            {
                if (sentence[i] != ' ')
                {
                    continue;
                }
                j = i;
                while (sentence[j]==' ')
                {
                    j++;
                }

                char1 = Char.ToLower(sentence[i - 1]);
                char2 = Char.ToLower(sentence[j]);

                if (char1 != char2)
                {
                    return false;
                }
                i = j;

            }
            return true;
        }
    }
}