using System.Net;
using System.Text.Json;
using MarolateCore.Application.Errors;
using MarolateCore.Application.Logging;

namespace MarolateCore.API.Middlewares
{
    public class GlobalExceptionMiddleware
    {
        /// <summary>
        /// Global exception handling middleware to catch unhandled exceptions, log them, and return a standardized error response.
        /// </summary>
        private readonly RequestDelegate _next;
        private readonly ILogService _logService;

        public GlobalExceptionMiddleware(RequestDelegate next, ILogService logService)
        {
            _next = next;
            _logService = logService;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                var traceId = Guid.NewGuid().ToString();

                await _logService.LogErrorAsync($"Unhandled exception | TraceId: {traceId}", ex);

                var errorResponse = new ErrorResponse
                {
                    TraceId = traceId,
                    Message = "Internal Server Error",
                    ErrorCode = "SYSTEM_ERROR",
                    StatusCode = (int)HttpStatusCode.InternalServerError,
                    Timestamp = DateTime.UtcNow
                };

                context.Response.ContentType = "application/json";
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                var json = JsonSerializer.Serialize(errorResponse);
                await context.Response.WriteAsync(json);
            }
        }
    }
}
