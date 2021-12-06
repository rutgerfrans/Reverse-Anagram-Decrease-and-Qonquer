using System;
using System.Collections.Generic;

namespace PI7Sstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sstring = "abcdefg";
            int Teller = 0;
            List<string> SstringList;
            SstringList = PopulateList(Sstring);
            SstringList = TurnSstringList(SstringList, Teller, Sstring);
            string TurnedSstring = PopulateString(SstringList);
        }

        private static List<string> PopulateList(string Sstring)
        {
            List<string> list = new List<string>();
            foreach (var Char in Sstring.ToCharArray())
            {
                list.Add(Char.ToString());
            }
            return list;
        }

        private static List<string> TurnSstringList(List<string> stringList, int Teller, string Sstring)
        {
            try
            {
                string CheckString = PopulateString(stringList);
                if (stringList.Count == Teller & CheckString == Sstring)
                {
                    return stringList;
                }
                else
                {
                    string key = stringList[stringList.Count - 1];
                    stringList.RemoveAt(stringList.Count - 1);
                    stringList.Insert(Teller, key);
                    string TempString = PopulateString(stringList);
                    Console.WriteLine(TempString);
                    TurnSstringList(stringList, Teller + 1, Sstring);
                }
                return stringList;
            }
            catch 
            {
                return stringList;
            }
        }

        private static string PopulateString(List<string> stringList)
        {
            string TurnedString = "";
            foreach (var Char in stringList)
            {
                TurnedString += Char;
            }
            return TurnedString;
        }


    }
}
