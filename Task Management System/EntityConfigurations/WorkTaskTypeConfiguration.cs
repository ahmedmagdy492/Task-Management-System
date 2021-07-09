using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_Lib.Models;

namespace Task_Management_Lib.EntityConfigurations
{
    public class WorkTaskTypeConfiguration : IEntityTypeConfiguration<WorkTask>
    {
        public void Configure(EntityTypeBuilder<WorkTask> builder)
        {
            builder.HasKey(t => t.Id);

            builder.HasMany(t => t.Attachments)
                .WithOne(a => a.WorkTask);

            builder.HasOne(t => t.User)
                .WithMany(u => u.WorkTasks);

            builder.HasOne(t => t.Group)
                .WithMany(g => g.WorkTasks);
        }
    }
}
