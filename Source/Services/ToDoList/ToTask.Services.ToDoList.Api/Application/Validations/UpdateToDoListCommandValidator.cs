using FluentValidation;
using ToTask.Services.ToDoList.Api.Application.Command;

namespace ToTask.Services.ToDoList.Api.Application.Validations
{
    public class UpdateToDoListCommandValidator : AbstractValidator<UpdateToDoListCommand>
    {

        public UpdateToDoListCommandValidator(IValidator<ToDoCommandDTO> todoValidator)
        {
            RuleFor(c => c.UserId).NotEmpty();
            RuleFor(c => c.Name).NotEmpty();
            RuleFor(d => d.ToDoListId).NotEmpty();

            RuleFor(c => c.Todos)
           .NotEmpty().When(c => c.Todos != null && c.Todos.Any())
           .WithMessage("A lista de tarefas não pode estar vazia quando há pelo menos um item.")
           .ForEach(item =>
           {
               item.SetValidator(todoValidator);
           });
        }
    }
}
