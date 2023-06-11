using System.Linq;

namespace CNAPP.Repository.Abstract
{
    public interface IBaseRepository<TEntity>
    {
        IQueryable<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void InsertAndComplete(TEntity entity);
        void Update(TEntity entity);
        void UpdateAndComplete(TEntity entity);
        void Delete(TEntity entity);
        void DeleteAndComplete(TEntity entity);
        void Complete();

    }
}
