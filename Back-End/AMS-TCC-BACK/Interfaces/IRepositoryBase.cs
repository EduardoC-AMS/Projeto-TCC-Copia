namespace AMS_TCC_BACK.Interfaces
{
    public interface IRepositoryBase<T>
    {
        Task<T> Add(T entity);
        Task<T> GetAll();
        Task<T> GetById(string id);
        Task<T> Update();
        Task<T> Delete();
    }
}