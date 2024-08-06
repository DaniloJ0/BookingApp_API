namespace BookingApp.Domain.Models.Jwt
{
    public interface IJwtTokenService
    {
        string GenerateToken(string userName, string role);
    }
}
