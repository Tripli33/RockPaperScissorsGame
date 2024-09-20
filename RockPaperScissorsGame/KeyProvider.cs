using System.Security.Cryptography;

namespace RockPaperScissorsGame;

public static class KeyProvider
{
    public static string GenerateRandomSecureKey256()
    {
        var keySize = 32;
        var key = new byte[keySize];

        using RandomNumberGenerator rng = RandomNumberGenerator.Create();
        rng.GetBytes(key);

        return BitConverter.ToString(key).Replace("-", "").ToLower();
    }
}
