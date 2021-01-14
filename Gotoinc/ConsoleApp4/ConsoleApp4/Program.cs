using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        public static void Main(string[] args)
        {

            char[] letters = new char[10];
            letters[0] = 'a';
            letters[1] = 'b';
            letters[2] = 'c';
            letters[3] = 'd';
            letters[4] = 'e';
            letters[5] = 'f';
            letters[6] = 'g';
            letters[7] = 'h';
            letters[8] = 'i';
            letters[9] = 'j';


            for (int i = 0; i < letters.Length; i++)
            {

                if ((i % 2) == 1)
                {
                    Console.WriteLine("Чётные биты " + letters[i]);
                }

                else
                    Console.WriteLine("Нечётные биты " + letters[i]);
            }

            for (int i = 0; i < letters.Length; i++)
            {

                if ((i % 2) == 1)
                {
                    Console.WriteLine("Even " + letters[i]);
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {

                if ((i % 2) != 1)
                {
                    Console.WriteLine("Odd: " + letters[i]);


                }
            }
            Console.ReadKey();
        }
    }
}
