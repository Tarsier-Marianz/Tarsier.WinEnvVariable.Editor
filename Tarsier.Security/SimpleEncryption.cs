using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Tarsier.Security
{
    public class SimpleEncryption {
        enum SymmetricCiphers { DES, AES, TripleDES, RC2 };
        public const string CRYPTO_KEY = @"eb 9c 68 0b ee 3a 48 35 2b af 20 a7 a7 19 62 25 
57 72 ca dd 9c fd cb 8b 4c 4f 0e 18 f8 e0 0e a4 
5b 16 52 7a 23 43 db ac 17 d3 43 80 ff 4d c6 e6
b4 6e a3 fe 80 00 b0 fd c1 f3 17 7b 8e 58 6a 88 
3a 34 ab 32 43 96 e3 ff 9e 1e b0 0c 1f 8d 41 35 
58 54 32 8e c0 a1 67 69 56 4f 84 d5 72 c5 80 45 
74 c7 a1 4f ";
        public const string CRYPTO_SALTKEY = @"7b 47 9f a2 70 50 9b 68 a5 f1 d8 b9 0e 47 db 5b 
d6 76 0d 8a f7 5c 2a f6 8b 16 31 24 7b 69 99 8f 
f4 96 76 af b6 e3 ad 54 db a0 fa 7d e3 c0 c0 da 
0e e2 8c 54 20 ed 9a fe 73 81 1b cf da 2b c9 a2 
29 d8 65 2c 2f 53 80 43 df 97 5c 54 49 cb 19 24 
3e ed f4 d2 f3 3e 0e 6f 22 9a c7 d1 94 6a f1 2f 
43 1b 66 39 ";



        public static SymmetricAlgorithm GetSelectedAlgorithm(int symAlg) {
            SymmetricAlgorithm Alg = null;
            if(symAlg == 0)
                Alg = new DESCryptoServiceProvider();
            else if(symAlg == 1)
                Alg = new RijndaelManaged();
            else if(symAlg == 2)
                Alg = new TripleDESCryptoServiceProvider();
            else
                Alg = new RC2CryptoServiceProvider();
            return Alg;
        }

        public static string Encrypt(string textToEncrypt, string salts, string key) {
            string encrypted = String.Empty;
            try {
                string password = key;
                string salt = salts;
                string txtToEncrypt = textToEncrypt;

                byte[] txtBytes = Encoding.ASCII.GetBytes(txtToEncrypt);

                Rfc2898DeriveBytes _rfc = new Rfc2898DeriveBytes(password, Encoding.ASCII.GetBytes(salt));

                SymmetricAlgorithm _symAlg = GetSelectedAlgorithm(0);

                _symAlg.Key = _rfc.GetBytes(_symAlg.KeySize / 8);
                _symAlg.IV = _rfc.GetBytes(_symAlg.BlockSize / 8);

                MemoryStream _strCiphered = new MemoryStream();

                CryptoStream _strCrypto = new CryptoStream(_strCiphered, _symAlg.CreateEncryptor(), CryptoStreamMode.Write);

                _strCrypto.Write(txtBytes, 0, txtBytes.Length);
                _strCrypto.Close();
                encrypted = Convert.ToBase64String(_strCiphered.ToArray());
                _strCiphered.Close();

            } catch(CryptographicException err) {
                string error = err.Message;
            }
            return encrypted;
        }

        public static string Decrypt(string textToDecrypt, string salts, string key) {
            string decrypted = String.Empty;
            try {
                if(!String.IsNullOrEmpty(textToDecrypt)) {
                    string password = key;
                    string salt = salts;
                    string _cypheredTxt = textToDecrypt;
                    byte[] _cypheredBytes = Convert.FromBase64String(_cypheredTxt);

                    Rfc2898DeriveBytes _rfc = new Rfc2898DeriveBytes(password,
                      Encoding.ASCII.GetBytes(salt));

                    SymmetricAlgorithm _symAlg = GetSelectedAlgorithm(0);

                    _symAlg.Key = _rfc.GetBytes(_symAlg.KeySize / 8);
                    _symAlg.IV = _rfc.GetBytes(_symAlg.BlockSize / 8);

                    MemoryStream strDeciphered = new MemoryStream();//To Store Decrypted Data

                    CryptoStream strCrypto = new CryptoStream(strDeciphered,
                        _symAlg.CreateDecryptor(), CryptoStreamMode.Write);

                    strCrypto.Write(_cypheredBytes, 0, _cypheredBytes.Length);
                    strCrypto.Close();
                    decrypted = Encoding.ASCII.GetString(strDeciphered.ToArray());
                    strDeciphered.Close();
                }
            } catch(CryptographicException err) {
                string error = err.Message;
            }

            return decrypted;
        }

        public static string Encrypt(string textToEncrypt) {
            if(String.IsNullOrEmpty(textToEncrypt)) {
                return String.Empty;
            }
            return Encrypt(textToEncrypt, CRYPTO_SALTKEY, CRYPTO_KEY);
        }
        public static string Decrypt(string textToDecrypt) {
            if(String.IsNullOrEmpty(textToDecrypt)) {
                return String.Empty;
            }
            return Decrypt(textToDecrypt, CRYPTO_SALTKEY, CRYPTO_KEY);
        }
    }
}