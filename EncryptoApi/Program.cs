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
            app.Run();


            string Encrypt(string input)
            {
                Encryption encrypt = new Encryption();

                string encrypted = encrypt.Encrypt(input);

                return $"Encrypt:  {encrypted}  ";
            }

            ///encrypt?input=Hejsan Robert
        }
        
    }
}
