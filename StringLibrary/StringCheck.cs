using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLibrary
{
    public class StringCheck
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="textString"></param>
        /// <returns></returns>
        public static List<char> GetLetters(string textString)
        {
            List<char> result = new List<char>();
            string letters = new String(textString.Where(Char.IsLetter).ToArray());

            char[] arrayChars = letters.ToCharArray();

            foreach (char item in arrayChars)
            {
                result.Add(char.ToUpper(item));
            }

            List<char> result2 = result.Distinct().ToList();
            result2.Sort();

            return result2;
        }
    }
}
