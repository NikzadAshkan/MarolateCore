using MarolateCore.Application.Security;

namespace MarolateCore.Infrastructure.Security
{
    public class RoleService : IRoleService
    {
        public Task<bool> UserHasRoleAsync(string userId, string role)
        {
            return Task.FromResult(true);
        }
    }
}
