using $ext_safeprojectname$.Application.Abstractions;
using $ext_safeprojectname$.Domain.Abstractions;
using $ext_safeprojectname$.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace $ext_safeprojectname$.Application.Services
{
    public class TodoService : ITodoService
    {
        readonly IRepository<TodoItem> repository;

        public TodoService(IRepository<TodoItem> repository) => this.repository = repository;


        //QUERIES
        public async Task<IList<TodoItem>> GetAllAsync()
        {
            IList<TodoItem> result = await Task.Run(() =>
                repository.GetAll().ToList()
            );

            return result;
        }

        public async Task<TodoItem> GetByIdAsync(Guid id)
        {
            TodoItem result = await Task.Run(() =>
                repository.GetAll().FirstOrDefault(x => x.Id == id)
            );

            return result;
        }


        //MUTATIONS
        public async Task<TodoItem> AddAsync(TodoItem item)
        {
            await repository.AddAsync(item);
            return item;
        }

        public async Task<TodoItem> UpdateAsync(TodoItem item)
        {
            await repository.UpdateAsync(item);
            return item;
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            return await repository.DeleteAsync(id);
        }
    }
}
