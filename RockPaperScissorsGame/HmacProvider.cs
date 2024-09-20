using System.Security.Cryptography;
using System.Text;

namespace RockPaperScissorsGame;

public static class HmacProvider
{
    public static string GenerateHmacWithSha256(string secureKey, string message)
    {
        var keyBytes = Encoding.UTF8.GetBytes(secureKey);
        var messageBytes = Encoding.UTF8.GetBytes(message);

        using HMACSHA256 hmac = new(keyBytes);
        var hashMessage = hmac.ComputeHash(messageBytes);

        return BitConverter.ToString(hashMessage).Replace("-", "").ToLower();
    }
}
