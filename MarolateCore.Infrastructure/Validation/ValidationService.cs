using MarolateCore.Application.Validation;

namespace MarolateCore.Infrastructure.Validation
{
    public class ValidationService<T> : IValidator<T>
    {
        public Task<ValidationResult> ValidateAsync(T model)
        {
            // فعلاً هیچ قانونی اعمال نمی‌شود
            return Task.FromResult(new ValidationResult
            {
                IsValid = true
            });
        }
    }
}
