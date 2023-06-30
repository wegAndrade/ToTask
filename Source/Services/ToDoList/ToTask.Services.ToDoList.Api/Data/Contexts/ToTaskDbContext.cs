using Microsoft.EntityFrameworkCore;

namespace ToTask.Services.ToDoList.Api.Data.Contexts
{
    public class ToTaskDbContext : DbContext
    {
        public ToTaskDbContext(DbContextOptions options) : base(options)
        {


        }
    }
}
