using MarolateCore.Application.Security;

namespace MarolateCore.Infrastructure.Security
{
    public class IdentityService : IIdentityService
    {
        public Task<bool> ValidateUserAsync(string username, string password)
        {
            // بعداً وصل به دیتابیس می‌شود
            return Task.FromResult(true);
        }

        public Task<string> GetUserIdAsync(string username)
        {
            return Task.FromResult(string.Empty);
        }
    }
}
