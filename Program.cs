using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextStatsLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Call our funtion using a three sentence string
            TextStats("Today is Tuesday.  Tomorrow is Wednesday.  The day after that is Thursday.");
            //Keep console open
            Console.ReadKey();
        }

        static void TextStats(string input)
        {
            input = input.ToLower();
            //print number of consonants
            Console.WriteLine("Number of Consonants: " + input.Where(x => "bcdfghjklmnpqrstvwxyz".Contains(x.ToString())).Count());
            // number of special characters
            Console.WriteLine("Number of Special Characters: " + input.Where(x => " ,.+=-_:;@#$%^&*".Contains(x.ToString())).Count());
            //number of words
            Console.WriteLine("Number of Words: " + input.Split(' ').Count());
            //number of vowels
            Console.WriteLine("Number of Vowels: " + input.Where(x => "aeiou".Contains(x.ToString())).Count());
            //total number of letters
            Console.WriteLine("Number of Letters: " + input.Length);
            //longest word
            Console.WriteLine("Longest Word: " + input.Split().OrderBy(x => x.Length).Last());
            //shortest word
            Console.WriteLine("Shortest Word: " + input.Split().OrderBy(x => x.Length).First());
            //print input
            Console.WriteLine(input);
            
        }
    }
}
