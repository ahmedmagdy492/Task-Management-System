using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_Management_Lib.EntityConfigurations;
using Task_Management_Lib.Models;

namespace Task_Management_Lib.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<WorkTask> WorkTasks { get; set; }
        public DbSet<GroupMessage> Messages { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new UserTypeConfiguration());
            modelBuilder.ApplyConfiguration(new GroupTypeConfigruation());
            modelBuilder.ApplyConfiguration(new WorkTaskTypeConfiguration());
            modelBuilder.ApplyConfiguration(new MessageTypeConfiguration());
        }
    }
}
