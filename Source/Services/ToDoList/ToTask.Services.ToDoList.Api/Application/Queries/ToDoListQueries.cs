using ToTask.Services.ToDoList.Api.Application.Responses;

namespace ToTask.Services.ToDoList.Api.Application.Queries
{
    public class ToDoListQueries : IToDoListQueries, IDisposable
    {
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoListResponse> Get(Guid taskListId, Guid userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDoListResponse>> GetAll(Guid userId)
        {
            throw new NotImplementedException();
        }
    }
}
