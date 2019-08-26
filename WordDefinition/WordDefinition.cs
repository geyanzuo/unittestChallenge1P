using System;
using System.Linq;

namespace WordDefinition
{
    public class WordDefinition
    {
    

        public string AlternatingCase(string input)
        {
            input = input.AlternateCase();
            return input;
        }

        public string ShiftWord(string input, int shiftamt)
        {
            input = input.ShiftAmt(shiftamt);
            return input;
        }

        public string MostCommonLetter(string input)
        {
            var charGroups = (from c in input
                              group c by c into g
                              select new
                              {
                                  c = g.Key,
                                  count = g.Count(),
                              }).OrderByDescending(c => c.count);
            return input;

            
        }

        public int AmtOfDifferentChars(string input)
        {
            int count = 0;
            
            foreach (char c in input)
            {
                if (input.Contains(c))
                    count++;
            }
            return count;

        }
    }


}
