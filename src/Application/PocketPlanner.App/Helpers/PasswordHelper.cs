using System.Security.Cryptography;

namespace PocketPlanner.App.Helpers;

public static class PasswordHelper
{
    public static byte[] GenerateSalt(int size)
    {
        var salt = new byte[size];
        using var rng = RandomNumberGenerator.Create();
        rng.GetBytes(salt);
        return salt;
    }

    public static string HashPassword(string password, byte[] salt, int iterations, int hashSize)
    {
        using var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, new HashAlgorithmName("PBDKF2"));
        var bytes =  pbkdf2.GetBytes(hashSize);
        return Convert.ToBase64String(bytes);
    }
}