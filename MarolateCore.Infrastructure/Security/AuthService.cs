using MarolateCore.Application.Security;

namespace MarolateCore.Infrastructure.Security
{
    public class AuthService : IAuthService
    {
        public Task<string> GenerateTokenAsync(string userId)
        {
            // فعلاً خالی — JWT بعداً پیاده‌سازی می‌شود
            return Task.FromResult(string.Empty);
        }

        public Task<bool> ValidateTokenAsync(string token)
        {
            // فعلاً خالی
            return Task.FromResult(true);
        }
    }
}
