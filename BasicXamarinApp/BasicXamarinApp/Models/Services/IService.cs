namespace BasicXamarinApp.Android.Models.Services
{
    public interface IService<TEntity>:IReadService<TEntity>,IWriteService<TEntity>
    {
    }
}