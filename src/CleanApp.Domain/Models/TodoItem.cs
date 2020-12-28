using System;
using System.Collections.Generic;
using System.Text;

namespace $ext_safeprojectname$.Domain.Models
{
    public class TodoItem : IModel
    {
        public Guid Id { get; set; }
        public bool IsDeleted { get; set; }

        public string Description { get; set; }
        public bool IsClosed { get; set; }

    }
}
