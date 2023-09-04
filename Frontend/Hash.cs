using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Frontend
{
    public static class Hash
    {

        public static string HashPassword(string password)
        {
            SHA1 pass = SHA1.Create();
            byte[] by = null;
            by = pass.ComputeHash(Encoding.Default.GetBytes(password));

            string hashed = " ";
            for (int i = 0; i < by.Length - 1; i++)
            {
                hashed += by[i].ToString("x2");
            }
            return hashed;
        }
    }
}