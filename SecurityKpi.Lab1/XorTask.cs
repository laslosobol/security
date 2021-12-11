using System.Collections.Generic;
using System.Text;

namespace SecurityKpi.Lab1
{
    public static class XorTask
    {
        public static IEnumerable<StringBuilder> GetResult(string text)
        {
            for (var key = 0; key < 256; key++)
            {
                var result = new StringBuilder();
                foreach (var t in text)
                {
                    result.Append((char)(t ^ (uint)key));
                }
                yield return result;
            }
        }
        public static StringBuilder GetResultRepeatingKey(string text)
        { 
            const string? key = "KEY";
            var result = new StringBuilder();
            for (var i = 0; i < text.Length; i++)
            {
                result.Append((char)(text[i] ^ key[i % key.Length]));
            }
            return result;
        }
    }
}