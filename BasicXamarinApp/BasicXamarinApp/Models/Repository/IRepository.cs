namespace BasicXamarinApp.Android.Models.Repository
{
    public interface IRepository<TEntity> : IReadRepository<TEntity>, IWriteRepository<TEntity>
    {
        
    }
}