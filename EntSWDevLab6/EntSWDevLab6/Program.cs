using System;

namespace EntSWDevLab6
{
    internal class Program
    {
        private static void Main()
        {
            var myChCipher = new Cipher();
            EncryptDelegate a = myChCipher.Cipher1;
            EncryptDelegate a2 = myChCipher.Cipher2;



            Console.WriteLine(a("abz"));
            Console.WriteLine(a2("abcde"));
            Console.ReadLine();
        }

        private delegate string EncryptDelegate(string plainText);
    }
}