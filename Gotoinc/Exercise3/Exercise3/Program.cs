using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Mani
    {

        public static void Main(string[] args)
        {
            string s = "Привет Мир,Привет С#,Привет Visual Studio";
            string[] separators = new string[] { "Привет" };

            string[] subs = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            foreach (string sub in subs)
            {
                Console.WriteLine($"Result: {sub}");

            }
            Console.WriteLine("Привет");
        }              
    }
}




