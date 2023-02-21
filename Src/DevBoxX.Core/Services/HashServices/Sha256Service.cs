using DevBoxX.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevBoxX.Core.Services.HashServices
{
    public class Sha256Service : IHasherService
    {
        public string Hash(string message)
        {
            if (string.IsNullOrEmpty(message) == true)
            {
                throw new ArgumentNullException("message can not be empty");
            } //end if
            using (var sha256Hash = SHA256.Create())
            {
                var sb = new StringBuilder();
                var bytesMessage = Encoding.UTF8.GetBytes(message);
                var bytesHash = sha256Hash.ComputeHash(bytesMessage);
                for (int i = 0; i < bytesHash.Length; i++)
                {
                    sb.Append(bytesHash[i].ToString("x1"));
                } //end for
                message = "";
                return sb.ToString();
            } //end using
        }
    }
}
