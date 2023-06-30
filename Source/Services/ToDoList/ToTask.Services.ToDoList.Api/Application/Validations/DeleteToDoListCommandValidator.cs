using FluentValidation;
using ToTask.Services.ToDoList.Api.Application.Command;

namespace ToTask.Services.ToDoList.Api.Application.Validations
{
    public class DeleteToDoListCommandValidator : AbstractValidator<DeleteToDoListCommand>
    {
        public DeleteToDoListCommandValidator()
        {
            RuleFor(d => d.ToDoListId).NotEmpty();
            RuleFor(d => d.UserId).NotEmpty();
        }
    }
}
