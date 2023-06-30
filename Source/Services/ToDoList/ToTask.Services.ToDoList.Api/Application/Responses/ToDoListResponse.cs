namespace ToTask.Services.ToDoList.Api.Application.Responses
{
    public class ToDoListResponse
    {

        public Guid ToDoListId { get; set; }

        public Guid UserId { get; set; }
        public string UserName { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public List<ToDoResponse> toDos { get; set; }




    }
}
