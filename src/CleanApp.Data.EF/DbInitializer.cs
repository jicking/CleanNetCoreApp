using $ext_safeprojectname$.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace $ext_safeprojectname$.Data.EF
{
    public class DbInitializer
    {
        public static void Initialize($ext_safeprojectname$Context context)
        {
            context.Database.EnsureCreated();

            // Check if DB has been seeded
            if (context.TodoItems.Any())
                return;

            context.TodoItems.Add(new TodoItem ()
            {
                Id = new Guid(),
                Description = "xx"
            });

            context.SaveChanges();
        }
    }
}
