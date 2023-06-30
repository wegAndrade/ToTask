using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ToTask.Services.ToDoList.Api.Models;

namespace ToTask.Services.ToDoList.Api.Data.Contexts.TypeConfigurations
{
    public class TodoTypeConfiguration : IEntityTypeConfiguration<ToDoModel>
    {
        public void Configure(EntityTypeBuilder<ToDoModel> builder)
        {
            builder.ToTable("Todo");
            builder.HasKey(t => t.ToDoId);
           
        }
    }
}
