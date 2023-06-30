using ToTask.Services.ToDoList.Api.Application.Responses;

namespace ToTask.Services.ToDoList.Api.Application.Queries
{
    public interface IToDoListQueries
    {

        Task<ToDoListResponse> Get(Guid taskListId, Guid userId);
        Task<IEnumerable<ToDoListResponse>> GetAll(Guid userId);
    }
}
