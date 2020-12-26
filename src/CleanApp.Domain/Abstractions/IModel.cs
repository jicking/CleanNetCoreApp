using System;
using System.Collections.Generic;
using System.Text;

namespace CleanApp.Domain.Models
{
    public interface IModel
    {
        Guid Id { get; set; }
        bool IsDeleted { get; set; }
    }
}
