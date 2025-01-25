using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionLibrary
{
    public class Encryption
    {
        public string Encrypt(string input)
        {
            string result = "";
            int shift = 3;

            foreach (char letter in input)
            {
                if (char.IsLetter(letter))
                {   
                    // Små Bokstav skifta
                    if (char.IsLower(letter))
                    {
                        char shifted = (char)((letter - 'a' + shift) % 26 + 'a');
                        result += shifted;
                    }
                    // Stora bokstav Skifta
                    else if (char.IsUpper(letter))
                    {
                        char shifted = (char)((letter - 'A' + shift) % 26 + 'A');
                        result += shifted;
                    }
                }
                // Nummer skifta
                else if (char.IsDigit(letter))
                {
                    char shifted = (char)((letter - '0' + shift) % 10 + '0');
                    result += shifted;
                }
                else
                {
                    // ÄÅÖ?
                    result += letter;
                }

            }
            return result;
        }

        public static string Decrypt(string input)
        {
            return input;
        }
    }
}
