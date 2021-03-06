﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TaskAgendaProj.Models
{
    public class TasksDbContext : DbContext
    {
        public TasksDbContext(DbContextOptions<TasksDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>(entity => {
                entity.HasIndex(u => u.Username).IsUnique();            //pune un index pe coloana username
            });

            
        }

        public DbSet<Task> Tasks { get; set; }
        public List<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
