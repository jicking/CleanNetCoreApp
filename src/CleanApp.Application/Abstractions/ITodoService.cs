using CleanApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanApp.Application.Abstractions
{
    public interface ITodoService
    {
        //QUERIES
        Task<IList<TodoItem>> GetAllAsync();
        Task<TodoItem> GetByIdAsync(Guid id);


        //MUTATIONS
        Task<TodoItem> AddAsync(TodoItem item);
        Task<TodoItem> UpdateAsync(TodoItem item);
        Task<bool> DeleteAsync(Guid id);
    }
}
