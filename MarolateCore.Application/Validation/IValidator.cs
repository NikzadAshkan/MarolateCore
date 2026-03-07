using System.ComponentModel.DataAnnotations;

namespace MarolateCore.Application.Validation
{
    public interface IValidator<T>
    {
        Task<ValidationResult> ValidateAsync(T model);
    }
}
