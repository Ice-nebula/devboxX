using DevBoxX.Core;
using DevBoxX.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DevBoxX.Core.Services.HashServices
{
    public class Md5Service : IHasherService
    {
        public string Hash(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException("message can not be empty");
            } //end if
            using (var hash = MD5.Create())
            {
                var bytesMessage = Encoding.UTF8.GetBytes(message);
                var hashResult = hash.ComputeHash(bytesMessage);
                var sb = new StringBuilder();
                for (int i = 0; i < hashResult.Length; i++)
                {
                    sb.Append(hashResult[i].ToString("x2"));
                } //end for loop
                return sb.ToString();
            } //end using
        }
    }
}
