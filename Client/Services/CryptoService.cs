namespace Services
{
    public class CryptoService
    {
        public string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string passwordCandidate, string hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(passwordCandidate, hashedPassword);
        }
    }
}
