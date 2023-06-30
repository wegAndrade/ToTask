using FluentValidation;
using ToTask.Services.ToDoList.Api.Application.Command;

namespace ToTask.Services.ToDoList.Api.Application.Validations
{
    public class ToDoCommandDTOValidator : AbstractValidator<ToDoCommandDTO>
    {
        public ToDoCommandDTOValidator()
        {

                ValidateDescription();
                ValidatePlannedDate();

        }

        public IRuleBuilderOptions<ToDoCommandDTO,string> ValidateDescription() => RuleFor(t => t.Description).NotEmpty();
        public IRuleBuilderOptions<ToDoCommandDTO,DateTime?> ValidatePlannedDate() => RuleFor(t => t.PlannedDate).NotNull();
    


    }
}
