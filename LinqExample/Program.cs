using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> values = new List<string> { "Herfawn", "gibbon", "R", "pHer",  "jackalope", "Herjack","abv" };

            string First=   SingleValue1.GetFirstSingleLetterWord(values);
            Console.WriteLine(First);

            string last = SingleValue1.GetLastWordWithHerInIt(values);
            Console.WriteLine(last);

            string Index = SingleValue1.GetFifthWordIfItExists(values);
            Console.WriteLine(Index);

            string last1 = SingleValue1.GetLastWordIfAny(values);
            Console.WriteLine(last1);




            //List<string> animalsname = new List<string> { "fawn", "gibbon", "heron", "ibex", "jackalope" };

            //IEnumerable<string> animals = from name in animalsname
            //                              where name.Length >= 5
            //                              orderby name.Length
            //                              select name;

            //IEnumerable<int> intvalue = new List<int> { 34, 68, 87, 1, 2, 2, 4, 7, 8, 9, 1 };


            //IEnumerable<string> list = FilterAndSort(animalsname, "o");
            ////IEnumerable<int> inlist= FilterEvenValue(intvalue);

            //foreach (var v in list)
            //{
            //    Console.WriteLine(v + ",");
            //}




            Console.ReadLine();
        }

        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            //var v = from value in inValues
            //        where value.Contains(pattern)
            //        orderby value
            //        select value;

            var v = inValues.Where(m =>m.Length>5 && m.Contains(pattern)).OrderBy(m => m).Select(m => m);
            return v;

        }

        public static IEnumerable<int> FilterEvenValue(IEnumerable<int> values)
        {
            //Query Syntax

            //var v = (from v1 in values
            //        where v1 % 2 == 0
            //        let t=v1*v1
            //        orderby v1
            //        select t).Distinct();

            //Method Syntax

            var v = values.Where(m => m % 2 == 0)

                .OrderBy(m => m)
                .Select(m => m * m).Distinct();


            return v;


        }
    }
}
