using System.Security.Cryptography;
using System.Text;

class TextHasher
{
    public static string Hash(string inputString)
    {
        using HashAlgorithm algorithm = SHA256.Create();
        StringBuilder sb = new StringBuilder();

        foreach (byte b in algorithm.ComputeHash(Encoding.UTF8.GetBytes(inputString))) sb.Append(b.ToString("X2"));

        return sb.ToString();
    }
}