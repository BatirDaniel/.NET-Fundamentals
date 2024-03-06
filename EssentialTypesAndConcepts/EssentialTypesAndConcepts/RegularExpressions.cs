using Microsoft.VisualBasic;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace EssentialTypesAndConcepts
{
    /// <summary>
    /// # The Regex class offers methods and properties to parse a large text to find patterns of characters
    /// 
    /// # Regex class provides methods and properties to work with regular expressions:
    ///    - Pattern matching: C# regex allows you to define patterns using special characters 
    ///      and constructs to match specific sequences of characters within a string.
    ///      
    ///    - Searching and replacing: You can use regex to search for patterns within a string
    ///      and replace them with other text or manipulate the matched portions of the string.
    ///      
    ///    - Validation: Regex is commonly used for validating user input.You can define a pattern
    ///      that input must match, and then check if the input string conforms to that pattern.
    ///      
    ///    - Splitting strings: Regex can be used to split strings based on a specified pattern, 
    ///      using regex, you can split a comma-separated list of values into individual elements.
    ///      
    ///    - Capturing groups: Regex allows you to define capturing groups, which are portions of
    ///      the pattern enclosed in parentheses.These groups can be used to extract specific parts
    ///      of a matched string.
    /// </summary>
    internal class RegularExpressions
    {
        public void RegexExamples()
        {
            // Create a pattern for a word that starts with the letter "M"
            string pattern = @"\b[M]\w+";
            Regex rg = new Regex(pattern);

            // A long string with a ton of white spaces
            string badString = "Here is a strig with ton of white space.";
            string CleanedString = Regex.Replace(badString, "\\s+", " ");
            Console.WriteLine($"Cleaned String: {CleanedString}");

            // Split a string on alphabetic character
            string azpattern = "[a-z]+";
            string str = "Asd2323b0900c1234Def5678Ghi9012Jklm";

            string[] result = Regex.Split(str, azpattern,
            RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(500));

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("'{0}'", result[i]);
                if (i < result.Length - 1)
                    Console.Write(", ");
            }
        }
    }
}
