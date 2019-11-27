using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EDIFACTParser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetEdifactMessage();
        }

        public static void GetEdifactMessage()
        {
            ArrayList arrayList = new ArrayList();
            string result = string.Empty;
            string edifact ="UNA:+.? '"+
                            "UNB+UNOC:3+2021000969+4441963198+180525:1225+3VAL2MJV6EH9IX+KMSV7HMD+CUSDECU-IE++1++1'"+
                            "UNH+EDIFACT+CUSDEC:D:96B:UN:145050'" +
                            "BGM+ZEM:::EX+09SEE7JPUV5HC06IC6+Z'" +
                            "LOC+17+IT044100'" +
                            "LOC+18+SOL'" +
                            "LOC+35+SE'" +
                            "LOC+36+TZ'" +
                            "LOC+116+SE003033'" +
                            "DTM+9:20090527:102'" +
                            "DTM+268:20090626:102'" +
                            "DTM+182:20090527:102'";

            var arrayOfLoc = edifact.Split("'").Where(x => x.StartsWith("LOC")).ToArray();
            foreach (var row in arrayOfLoc)
            {
                string[] items = row.Split('+').ToArray();
                arrayList.Add(items[1]);
                arrayList.Add(items[2]);

                result += items[0] + " - " + items[1] + "\r\n";
            }

            Console.WriteLine(result);
            Console.ReadKey();
        }
               
       


    }
}
