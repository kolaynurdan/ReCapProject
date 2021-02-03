namespace ReCapProject.Common.DataAccess
{
    using System.Collections.Generic;

    using ReCapProject.Common.Entity;

    public interface IEntityRepositoryBase<TEntity>
    where TEntity: IEntity
    {
        /* GetById, GetAll, Add, Update, Delete */
        void Add(TEntity entity );
        void Update(TEntity entity);
        void Delete(TEntity entity);
        TEntity GetById(int ıd);
        List<TEntity> GetAll();

    }

    public class EfEntityRepositoryBase<TEntity>: IEntityRepositoryBase<TEntity>
        where TEntity : IEntity
    {
        
        public void Add(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public TEntity GetById(int Id)
        {
            throw new System.NotImplementedException();
        }

        public List<TEntity> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}