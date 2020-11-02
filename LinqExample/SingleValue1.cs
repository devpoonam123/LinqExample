using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
   public static class SingleValue1
    {
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            var v = words.FirstOrDefault(val=>val.Length==1);
            return v;
        }

        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            var v = words.LastOrDefault(val => val.Contains("Her"));
            return v;
        }

        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            var v = words.ElementAtOrDefault(9-1);
            return v;
        }

        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            var v = words.LastOrDefault();
            return v;
        }
    }
}
