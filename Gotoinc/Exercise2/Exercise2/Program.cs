using System;
using System.IO;
using System.Linq;
using System.Security.AccessControl;

namespace Exercise2
{

    class Program
    {
        static void Main(string[] args)
        {

            ushort secretKey = 0x0008; 


            string str = "Hello World"; 

            str = EncodeDecrypt(str, secretKey); 
            Console.WriteLine(str);  

            str = EncodeDecrypt(str, secretKey); 
            Console.WriteLine(str);             
            Console.ReadKey();

        }

        public static string EncodeDecrypt(string str, ushort secretKey)
        {
            var ch = str.ToArray(); 
            string newStr = "";      
            foreach (char c in ch)  
                newStr += TopSecret(c, secretKey);  
            return newStr;
        }

        public static char TopSecret(char character, ushort secretKey)
        {
            character = (char)(character ^ secretKey); 
            return character;
        }
    }
}


