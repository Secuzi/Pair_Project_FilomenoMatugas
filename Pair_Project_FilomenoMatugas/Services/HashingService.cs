
using System.Security.Cryptography;
using System.Text;
namespace Pair_Project_FilomenoMatugas.Services
{
    public class HashingService
    {
        public static string HashData(string userData)
        {
            using(SHA256 sha256Hash = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(userData);
                byte[] hashBytes = sha256Hash.ComputeHash(inputBytes);

                StringBuilder builder = new StringBuilder();
                for(int i  = 0; i < hashBytes.Length; i++)
                {
                    builder.Append(hashBytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
