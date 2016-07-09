using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace huypq.Crypto.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var p = new PasswordHash();
            var r = p.HashedBase64String("this is a password");
            var resultTrue = PasswordHash.VerifyHashedPassword(r, "this is a password");
            var resultFalse = PasswordHash.VerifyHashedPassword(r, "this is another password");
        }
    }
}
