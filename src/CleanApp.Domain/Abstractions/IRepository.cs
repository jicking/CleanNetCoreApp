using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $ext_safeprojectname$.Domain.Abstractions
{
    public interface IRepository<TModel>
    {
        IQueryable<TModel> GetAll();

        Task<TModel> AddAsync(TModel entity);

        Task<TModel> UpdateAsync(TModel entity);

        Task<bool> DeleteAsync(Guid id);
    }
}
