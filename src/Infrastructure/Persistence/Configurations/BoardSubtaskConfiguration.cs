using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RestApiTemplate.Domain.Entities;

namespace RestApiTemplate.Infrastructure.Persistence.Configurations;
public class BoardSubtaskConfiguration : IEntityTypeConfiguration<BoardSubtask>
{
    public void Configure(EntityTypeBuilder<BoardSubtask> builder)
    {
        builder
            .HasOne<BoardTask>(bt => bt.BoardTask)
            .WithMany(t => t.BoardSubtasks)
            .HasForeignKey(bt => bt.BoardTaskId)
            .OnDelete(DeleteBehavior.Cascade);
            
        builder.Property(t => t.Title)
            .HasMaxLength(200)
            .IsRequired();
    }
}
