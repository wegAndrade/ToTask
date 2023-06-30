using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToTask.Services.ToDoList.Api.Models;

namespace ToTask.Services.ToDoList.Api.Data.Contexts.TypeConfigurations
{
    public class ToDoListTypeConfiguration : IEntityTypeConfiguration<ToDoListModel>
    {
        public void Configure(EntityTypeBuilder<ToDoListModel> builder)
        {
            builder.ToTable("TodoList");
            builder.HasKey(tl => tl.ToDoListId);
            builder.HasMany(tl => tl.toDos).WithOne().HasForeignKey(tl => tl.ToDoListId);   

        }
    }
}
