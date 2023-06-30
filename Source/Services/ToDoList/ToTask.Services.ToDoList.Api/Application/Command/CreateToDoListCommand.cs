using MediatR;

namespace ToTask.Services.ToDoList.Api.Application.Command
{
    public class CreateToDoListCommand : IRequest<bool>
    {
        public Guid UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        private readonly List<ToDoCommandDTO> _todos;
        public IEnumerable<ToDoCommandDTO> Todos => _todos;

        public CreateToDoListCommand(Guid userId, string name, string description, List<ToDoCommandDTO> toDoDTOs)
        {
            UserId = userId;
            Name = name;
            Description = description;
            _todos = toDoDTOs;
        }
    }
   
}
