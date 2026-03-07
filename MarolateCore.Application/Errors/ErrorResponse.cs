namespace MarolateCore.Application.Errors
{
    public class ErrorResponse
    {
        /// <summary>
        /// A unique identifier for the error instance, useful for tracing and debugging purposes.
        /// </summary>
        public string TraceId { get; set; }
        public string Message { get; set; }
        public string ErrorCode { get; set; }
        public int StatusCode { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
