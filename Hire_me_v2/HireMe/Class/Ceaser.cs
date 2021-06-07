using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hire_me_v2.HireMe.Class
{
    public class Ceaser
    {
        public static char cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }
            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }
        public static string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char item in input)
            {
                output += cipher(item, key);
            }
            return output;
        }
        public static string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}