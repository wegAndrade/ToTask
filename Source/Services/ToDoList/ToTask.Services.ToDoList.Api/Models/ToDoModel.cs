namespace ToTask.Services.ToDoList.Api.Models
{
    public class ToDoModel
    {
        public Guid ToDoId { get; set; }
        public Guid ToDoListId { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime PlannedDate { get; set;}

        public bool FinishedDate { get; set; }
    }
}