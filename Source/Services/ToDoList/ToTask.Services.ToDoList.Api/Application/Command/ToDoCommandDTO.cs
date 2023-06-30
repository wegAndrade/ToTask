namespace ToTask.Services.ToDoList.Api.Application.Command
{
    public class ToDoCommandDTO
    {

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? PlannedDate { get; set; }

        public bool Finished { get; set; }
    }
}
