using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Int32, string> dict = new Dictionary<Int32, string>();

            dict[44] = "United Kingdom";
            dict[33] = "France";
            dict[31] = "Netherlands";
            dict[55] = "Brazil";


            Console.WriteLine("The 55 Code is for: {0}", dict[55]);


            foreach (KeyValuePair<Int32,string> item in dict)
            {
                int code = item.Key;
                string country = item.Value;
                Console.WriteLine("Code {0} = {1}", code, country);
            }

            Console.Read();

        }
    }
}
