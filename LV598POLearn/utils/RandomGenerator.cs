using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV598POLearn.utils
{
    public class RandomGenerator
    {
        public static string GenerateWord(int length, int startAscii, int endAscii)
        {
            Random rand = new Random();
            StringBuilder word = new StringBuilder("");
            for (int i = 0; i < length; i++)
            {
                int letterAsc = rand.Next(0, endAscii - startAscii);
                char letter = Convert.ToChar(startAscii + letterAsc);
                word.Append(letter);
            }
            return Convert.ToString(word);
        }
    }
}
