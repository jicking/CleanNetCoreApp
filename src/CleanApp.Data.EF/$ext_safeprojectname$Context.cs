using $ext_safeprojectname$.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace $ext_safeprojectname$.Data.EF
{
    public class $ext_safeprojectname$Context: DbContext
    {

        public $ext_safeprojectname$Context(DbContextOptions<$ext_safeprojectname$Context> options) :base(options) { }


        public DbSet<TodoItem> TodoItems { get; set; }

    }
}
