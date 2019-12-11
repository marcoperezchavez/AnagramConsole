using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace anagrams
{
    class Program
    {
        static List<string> anagramList = new List<string>();
        static void Main(string[] args)
        {
            try
            {
                string filePath = @"D:\wl.txt";
                string letterToLooking = "leba";
                var file = new StreamReader(filePath);                                                          

                var arrayLines = true;                  
                

                while (arrayLines ==true)
                {
                    var lin = file.ReadLine();
                    arrayLines = lin == null ? false : checkAnagram(lin , letterToLooking);
                }

                showAnagram(anagramList);
                file.Close();
            }
            catch (Exception ex)
            {
                var exceptionResult = ex;
            }
        }

        private static void showAnagram(List<string> anagramList)
        {
            if(anagramList != null)
            {
                foreach (var anag in anagramList)
                {
                    Console.WriteLine(anag);
                }
            }
            else
            {
                Console.WriteLine("DOes not exist anagram");
            }
            Console.ReadLine();
        }

        private static bool checkAnagram(string lin, string letterToLooking)
        {
                if (letterToLooking.Length == lin.Length)
                {
                    var res = letterToLooking.OrderBy(c => c).SequenceEqual(lin.OrderBy(c => c));
                    if (res)
                    {
                        anagramList.Add(lin);
                    }
                }
            return true;
            
        }
    }
}
