namespace MarolateCore.Application.Logging
{
    public interface ILogService
    {
        Task LogInfoAsync(string message);
        Task LogWarningAsync(string message);
        Task LogErrorAsync(string message, Exception ex = null);
        Task LogAuditAsync(string userId, string action, string entityName);
    }
}
