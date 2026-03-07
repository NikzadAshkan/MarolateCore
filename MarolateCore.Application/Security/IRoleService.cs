namespace MarolateCore.Application.Security
{
    public interface IRoleService
    {
        Task<bool> UserHasRoleAsync(string userId, string role);
    }
}
