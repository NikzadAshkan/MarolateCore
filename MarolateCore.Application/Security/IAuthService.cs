namespace MarolateCore.Application.Security
{
    public interface IAuthService
    {
        Task<string> GenerateTokenAsync(string userId);
        Task<bool> ValidateTokenAsync(string token);
    }
}
