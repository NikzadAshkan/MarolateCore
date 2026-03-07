namespace MarolateCore.Application.Security
{
    public interface IIdentityService
    {
        Task<bool> ValidateUserAsync(string username, string password);
        Task<string> GetUserIdAsync(string username);
    }
}
