using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace DictionaryCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable();
            h["0"] = "Zero";
            h["1"] = "One";
            h["2"] = "Two";
            h["3"] = "Three";
            h["4"] = "Four";
            h["5"] = "Five";
            h["6"] = "Six";
            h["7"] = "Seven";
            h["8"] = "Eight";
            h["9"] = "Nine";


            string number = "3332214567832";
            Console.WriteLine(number);
            foreach (char c in number)
            {
                string digit = c.ToString();
                if (h.ContainsKey(digit))
                {
                    Console.WriteLine(h[digit]);
                }
            }

            Console.ReadKey();
        }
    }
}
