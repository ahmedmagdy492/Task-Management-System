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
    public class MessageTypeConfiguration : IEntityTypeConfiguration<GroupMessage>
    {
        public void Configure(EntityTypeBuilder<GroupMessage> builder)
        {
            builder.HasKey(m => m.Id);

            builder.HasOne(m => m.Sender)
                .WithMany(s => s.Messages);

            builder.HasOne(m => m.Group)
                .WithMany(g => g.Messages);
        }
    }
}
