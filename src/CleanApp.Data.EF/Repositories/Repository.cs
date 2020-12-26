using CleanApp.Domain.Abstractions;
using CleanApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanApp.Data.EF.Repositories
{
    public class Repository<TModel> : IRepository<TModel> where TModel : class, IModel, new()
    {
        readonly CleanAppContext db;

        public Repository(CleanAppContext dbContext) => db = dbContext;



        public IQueryable<TModel> GetAll()
        {
            return db.Set<TModel>();
        }

        public async Task<TModel> AddAsync(TModel entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                entity.Id = new Guid();
                await db.AddAsync(entity);
                await db.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TModel> UpdateAsync(TModel entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(AddAsync)} entity must not be null");
            }

            try
            {
                db.Update(entity);
                await db.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await db.Set<TModel>().FindAsync(id);

            if (entity == null)
            {
                throw new OperationCanceledException($"{nameof(AddAsync)} entity does not exist in DB.");
            }

            try
            {
                entity.IsDeleted = true;

                db.Update(entity);
                await db.SaveChangesAsync();

                return true;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be deleted: {ex.Message}");
            }
        }
    }
}
