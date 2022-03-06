using System.Text;
using System.Text.RegularExpressions;

namespace TwitchVrcAvatarOSC
{
    public static class Extensions
    {
        public static object ConvertStringToObject(this string str)
        {
            if (bool.TryParse(str, out bool b))
            {
                return b;
            }
            else if (int.TryParse(str, out int i))
            {
                return i;
            }
            else if (double.TryParse(str, out double d))
            {
                return d;
            }
            return null;
        }

        public static IEnumerable<string> SplitToLines(this string stringToSplit, int maxLineLength)
        {
            string[] words = stringToSplit.Split(' ');
            StringBuilder line = new StringBuilder();
            foreach (string word in words)
            {
                if (word.Length + line.Length <= maxLineLength)
                {
                    line.Append(word + " ");
                }
                else
                {
                    if (line.Length > 0)
                    {
                        yield return line.ToString().Trim();
                        line.Clear();
                    }
                    string overflow = word;
                    while (overflow.Length > maxLineLength)
                    {
                        yield return overflow.Substring(0, maxLineLength);
                        overflow = overflow.Substring(maxLineLength);
                    }
                    line.Append(overflow + " ");
                }
            }
            yield return line.ToString().Trim();
        }
    }
}
