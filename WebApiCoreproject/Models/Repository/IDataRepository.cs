namespace WebApiCoreproject.Models.Repository
{
    public interface IDataRepository<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntitys, TEntity entity);
        void Delete(TEntity entity);

    }
}
