using System;
using System.Collections.Generic;
using System.Text;

namespace $ext_safeprojectname$.Domain.Models
{
    public interface IModel
    {
        Guid Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
