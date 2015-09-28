using System;
using System.Diagnostics;

namespace EntSWDevLab6
{
    public class Cipher
    {
        public string Cipher1(string plainText)
        {
            var cipherText = "";
            if (plainText != null)
            {
                // LINQ version of this foreach loop
                //cipherText = plainText.Select(c => (char) ((c + 1)%(int) char.MaxValue)).Aggregate(cipherText, (current, c2) => current + c2);
                foreach (var c in plainText)
                {
                    var c2 = (char)( (c + 1) % (int)char.MaxValue);
                    cipherText = cipherText + c2;
                }
            }
            return cipherText;
        }

        public string Cipher2(string plainText)
        {
            Debug.Assert(plainText != null, "plainText != null");
            var arr = plainText.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}