﻿using ForumApp24.Infrastructure.Data.Configuration;
using ForumApp24.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumApp24.Infrastructure.Data
{
    public class Forum24DbContext: DbContext
    {
        public Forum24DbContext(DbContextOptions<Forum24DbContext> options)
            :base(options) 
        { 
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PostConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Post> Posts { get; set; }
    }
}
