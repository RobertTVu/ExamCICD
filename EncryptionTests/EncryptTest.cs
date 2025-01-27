using EncryptionLibrary;

namespace EncryptionTests
{
    public class EncryptTest
    {
        [Theory]
        [InlineData("Hejsan Robert", 3, "Khmvdq Urehuw")]
        [InlineData("Github Action123", 3, "Jlwkxe Dfwlrq456")]
        public void EncrypTest(string input, int shift, string expectedResult )
        {
            // Arrange
            Encryption encryption = new Encryption();
      
            // Act
            string result = encryption.Encrypt(input, shift);

            // Assert
            Assert.Equal(result, expectedResult);

        }

        [Theory]
        [InlineData("Khmvdq Urehuw!", 3, "Hejsan Robert!")]
        [InlineData("333!", 3, "000!")]
        public void DecryptTest(string input, int shift, string expectedResult)
        {
            Encryption decryption = new Encryption();

            string result = decryption.Decrypt(input, shift);

            Assert.Equal(expectedResult, result);
        }

    }
}
