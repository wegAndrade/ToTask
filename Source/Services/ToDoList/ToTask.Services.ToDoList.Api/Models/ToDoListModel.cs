namespace ToTask.Services.ToDoList.Api.Models
{
    public class ToDoListModel
    {
        public Guid ToDoListId { get; set; }

        public Guid UserId { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

       public List<ToDoModel> toDos { get; set; }

    }
}
