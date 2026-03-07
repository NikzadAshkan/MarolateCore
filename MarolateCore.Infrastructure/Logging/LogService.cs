using MarolateCore.Application.Logging;

namespace MarolateCore.Infrastructure.Logging
{
    public class LogService : ILogService
    {
        public Task LogInfoAsync(string message)
        {
            Console.WriteLine($"[INFO] {message}");
            return Task.CompletedTask;
        }

        public Task LogWarningAsync(string message)
        {
            Console.WriteLine($"[WARNING] {message}");
            return Task.CompletedTask;
        }

        public Task LogErrorAsync(string message, Exception ex = null)
        {
            Console.WriteLine($"[ERROR] {message}");
            if (ex != null)
                Console.WriteLine(ex.ToString());

            return Task.CompletedTask;
        }

        public Task LogAuditAsync(string userId, string action, string entityName)
        {
            Console.WriteLine($"[AUDIT] User:{userId} Action:{action} Entity:{entityName}");
            return Task.CompletedTask;
        }
    }
}
