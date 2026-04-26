using Konscious.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Messanger
{
    public static class PasswordHashing
    {
        public static byte[] HashPasswordArgon2id(string password, out byte[] salt)  
        {
            salt = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(salt);
            }

            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = salt,
                Iterations = 3,
                MemorySize = 65536,
                DegreeOfParallelism = 2
            };

            return argon2.GetBytes(32);
        }

        public static bool VerifyPasswordArgon2id(string password, byte[] storedSalt, byte[] storedHash) // HASHING
        {
            var argon2 = new Argon2id(Encoding.UTF8.GetBytes(password))
            {
                Salt = storedSalt,
                Iterations = 3,
                MemorySize = 65536,
                DegreeOfParallelism = 2
            };

            byte[] computedHash = argon2.GetBytes(32);

            return FixedTimeEquals(computedHash, storedHash);
        }

        private static bool FixedTimeEquals(byte[] a, byte[] b) // HASHING
        {
            if (a == null || b == null || a.Length != b.Length)
                return false;

            int diff = 0;
            for (int i = 0; i < a.Length; i++)
            {
                diff |= a[i] ^ b[i];
            }

            return diff == 0;
        }
    }
}
