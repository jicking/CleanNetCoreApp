using CleanApp.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp.Data.EF
{
    public class CleanAppContext: DbContext
    {

        public CleanAppContext(DbContextOptions<CleanAppContext> options) :base(options) { }


        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
