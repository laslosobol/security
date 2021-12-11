using System;

namespace SecurityKpi.Lab1
{
    public class Utils
    {
        public static string Hex2Ascii( string hex)

        {

            string res = string.Empty ;

            for (var a = 0; a <hex.Length ; a += 2)

            {

                string char2Convert = hex.Substring(a, 2);

                var n = Convert.ToInt32(char2Convert, 16);

                var c = (char)n;

                res += c.ToString();

            }

            return res;

        }
    }
}