namespace ToTask.Services.ToDoList.Api.Application.Responses
{
    public class ToDoResponse
    {
        public Guid ToDoId { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime PlannedDate { get; set; }

        public bool FinishedDate { get; set; }

        public bool IsLate => PlannedDate > DateTime.Now;
    }
}
