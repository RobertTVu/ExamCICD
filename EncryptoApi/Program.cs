using EncryptionLibrary;

namespace EncryptoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Welcome to Encryption!");
            app.MapGet("/encrypt", (string input) => Encrypt(input));
            app.MapGet("/decrypt", (string input) => Decrypt(input));
            app.Run();





            string Encrypt(string input)
            {
                Encryption encrypt = new Encryption();
                string encrypted = encrypt.Encrypt(input, 3);
                return $"Encrypt:  {encrypted}  ";
            }

            string Decrypt(string input)
            {
                Encryption decrypt = new Encryption();
                string decrypted = decrypt.Decrypt(input, 3);
                return $"Decrypt:  {decrypted}  ";
            }
            ///encrypt?input=Hejsan Robert
        }
        
    }
}
