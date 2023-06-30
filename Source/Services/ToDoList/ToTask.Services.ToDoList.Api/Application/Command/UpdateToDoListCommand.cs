namespace ToTask.Services.ToDoList.Api.Application.Command
{
    public class UpdateToDoListCommand
    {
        public Guid ToDoListId { get; set; }
        public Guid UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        private readonly List<ToDoCommandDTO> _todos;
        public IEnumerable<ToDoCommandDTO> Todos => _todos;

        public UpdateToDoListCommand(Guid todoListId,Guid userId, string name, string description, List<ToDoCommandDTO> toDoDTOs)
        {
            ToDoListId = todoListId;
            UserId = userId;
            Name = name;
            Description = description;
            _todos = toDoDTOs;
        }
    }
}
