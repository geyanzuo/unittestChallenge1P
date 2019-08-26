using System;
using System.Collections.Generic;
using System.Text;

namespace WordDefinition
{
    public static class StringExtension
    {
        public static string AlternateCase(this string original)
        {
            string reslut = string.Empty;

            char[] chars = original.ToCharArray();
            for (int i =0; i < chars.Length; i++)
            {
                if (i%2 == 0)
                {
                    reslut += chars[i].ToString().ToLower();
                }
                else
                {
                    reslut += chars[i].ToString().ToUpper();
                }
            }
            return reslut;
        }


        public static string ShiftAmt(this string original, int shiftamt)
        {
            string result = string.Empty;
            char[] chars = original.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == 'Z')
                {
                    result += chars[i] = 'A';
                }

                else if (chars[i] == 'z')
                {
                    result += chars[i] = 'a';
                }
                else
                {
                    result += chars[i] = (char)(((int)chars[i]) + shiftamt);
                }
            }

            return result;
        }

    }

    
}
