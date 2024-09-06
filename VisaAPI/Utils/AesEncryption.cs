using System.Security.Cryptography;
using System.Text;

namespace VisaAPI.Utils
{
    public class AesEncryption
    {
        // Encrypt a string to Base64 using AES
        public static string EncryptToBase64(string plainText, byte[] key)
        {
            // Generate a random 16-byte IV
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;
                aesAlg.GenerateIV(); // Random IV

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    // Write the IV at the start of the stream (for use in decryption)
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            // Write the data to the stream
                            swEncrypt.Write(plainText);
                        }
                    }

                    // Convert to Base64
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        // Decrypt a Base64 string using AES
        public static string DecryptFromBase64(string cipherTextBase64, byte[] key)
        {
            byte[] fullCipher = Convert.FromBase64String(cipherTextBase64);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = key;

                // Extract the IV from the beginning of the fullCipher
                byte[] iv = new byte[aesAlg.BlockSize / 8];
                Array.Copy(fullCipher, iv, iv.Length);

                aesAlg.IV = iv;

                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Decrypt the message
                using (MemoryStream msDecrypt = new MemoryStream(fullCipher, iv.Length, fullCipher.Length - iv.Length))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            // Read the decrypted bytes and return as a string
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }
        public static byte[] CreateKey(string keyString)
        {
            // Convert the key string to a byte array
            byte[] key = Encoding.UTF8.GetBytes(keyString);

            // Ensure the key is exactly 32 bytes long
            if (key.Length > 32)
            {
                // Trim the key if it's too long
                return key.Take(32).ToArray();
            }
            else if (key.Length < 32)
            {
                // Pad the key with extra bytes if it's too short
                return key.Concat(new byte[32 - key.Length]).ToArray();
            }

            return key;

        }
    }
}