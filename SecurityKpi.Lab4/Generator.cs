using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace SecurityKpi.Lab4
{
    public static class Generator
    {
        private static readonly string[] Passwords100 = File.ReadAllLines(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\passwords\passwords100.txt");
        private static readonly string[] Passwords = File.ReadAllLines(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\passwords\passwords.txt");
        private static readonly string[] PasswordsReadable = File.ReadAllLines(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\passwords\passwordsReadable.txt");
        private static readonly string[] PasswordsUnreadable = File.ReadAllLines(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\passwords\passwordsUnreadable.txt");
        private static readonly Random Random = new Random();
        public static void GenerateMd5Passwords()
        {

            var toCsv = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                var temp = Random.Shared.NextDouble();
                byte[]? inputBytes;
                byte[]? hashBytes;
                StringBuilder sb;
                switch (temp)
                {
                    case >= 0 and < 0.07:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords100[Random.NextInt64(0, 99)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.07 and < 0.92:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords[Random.NextInt64(0, 99999)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.92 and < 0.96:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsReadable[Random.NextInt64(0, 4999)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.96 and < 1:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsUnreadable[Random.NextInt64(0, 4999)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                }
            }
            File.WriteAllText(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\results\md5.csv", toCsv.ToString());
        }
        public static void GenerateSha1Passwords()
        {
            var random = new Random();
            var toCsv = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                var temp = Random.Shared.NextDouble();
                byte[]? inputBytes;
                byte[]? hashBytes;
                StringBuilder sb;
                switch (temp)
                {
                    case >= 0 and < 0.07:
                        using (SHA1 sha1 = SHA1.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords100[Random.NextInt64(0, 99)]);
                            hashBytes = sha1.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.07 and < 0.92:
                        using (SHA1 sha1 = SHA1.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords[Random.NextInt64(0, 99999)]);
                            hashBytes = sha1.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.92 and < 0.96:
                        using (SHA1 sha1 = SHA1.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsReadable[Random.NextInt64(0, 4999)]);
                            hashBytes = sha1.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.96 and < 1:
                        using (SHA1 sha1 = SHA1.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsUnreadable[Random.NextInt64(0, 4999)]);
                            hashBytes = sha1.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                }
            }
            File.WriteAllText(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\results\sha1.csv", toCsv.ToString());
        }
        public static void GenerateArgon2IPasswords()
        {
            var random = new Random();
            var toCsv = new StringBuilder();
            for (var i = 0; i < 100000; i++)
            {
                var temp = Random.Shared.NextDouble();
                byte[]? inputBytes;
                byte[]? hashBytes;
                StringBuilder sb;
                switch (temp)
                {
                    case >= 0 and < 0.07:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords100[Random.NextInt64(0, 99)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.07 and < 0.92:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(Passwords[Random.NextInt64(0, 99)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.92 and < 0.96:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsReadable[Random.NextInt64(0, 99)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                    case >= 0.96 and < 1:
                        using (MD5 md5 = MD5.Create())
                        {
                            inputBytes = Encoding.ASCII.GetBytes(PasswordsUnreadable[Random.NextInt64(0, 99)]);
                            hashBytes = md5.ComputeHash(inputBytes);

                            // Convert the byte array to hexadecimal string
                            sb = new StringBuilder();
                            foreach (var t in hashBytes)
                            {
                                sb.Append(t.ToString("X2"));
                            }
                            toCsv.AppendLine(sb.ToString());
                        }
                        break;
                }
            }
            File.WriteAllText(@"B:\CSharp\SecurityKpi\SecurityKpi.Lab4\results\argon2i.csv", toCsv.ToString());
        }
        private static string CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }
        static byte[] GenerateSaltedHash(byte[] plainText, byte[] salt)
        {
            HashAlgorithm algorithm = new SHA256Managed();

            byte[] plainTextWithSaltBytes = 
                new byte[plainText.Length + salt.Length];

            for (int i = 0; i < plainText.Length; i++)
            {
                plainTextWithSaltBytes[i] = plainText[i];
            }
            for (int i = 0; i < salt.Length; i++)
            {
                plainTextWithSaltBytes[plainText.Length + i] = salt[i];
            }

            return algorithm.ComputeHash(plainTextWithSaltBytes);            
        }
    }
}