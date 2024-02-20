using System.Text;

namespace SzyfrCezara.Services
{
    public class CeaserService
    {
        private static string lowerAlphabet = "aąbcćdeęfghijklłmnńoóprsśtuvwxyzźż";
        private static string upperAlphabet = "AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUVWXYZŹŻ";
        public static string Encrypt(string plainText, int shift)
        {
            StringBuilder cipherText = new StringBuilder();

            foreach (char c in plainText)
            {
                string alphabet = char.IsUpper(c) ? upperAlphabet : lowerAlphabet;
                int index = alphabet.IndexOf(c);
                if (index != -1)
                {
                    int shiftedIndex = (index + shift) % alphabet.Length;
                    cipherText.Append(alphabet[shiftedIndex]);
                }
                else
                {
                    cipherText.Append(c);
                }
            }

            return cipherText.ToString();
        }

        public static string Decrypt(string cipherText, int shift)
        {
            return Encrypt(cipherText, lowerAlphabet.Length - shift);
        }

    }
}
