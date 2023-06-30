using MediatR;

namespace ToTask.Services.ToDoList.Api.Application.Command
{
    public class DeleteToDoListCommand: IRequest<bool>
    {
        public Guid ToDoListId { get; set; }
        public Guid UserId { get; set; }

        public DeleteToDoListCommand(Guid toDoListId, Guid userId)
        {
            ToDoListId = toDoListId;
            UserId = userId;
        }
    }
}
