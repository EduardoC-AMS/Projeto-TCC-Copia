using AMS_TCC_BACK.Interfaces;

namespace AMS_TCC_BACK.Service
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        public Task<T> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<T> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(string id)
        {
            throw new NotImplementedException();
        }

        public Task<T> Update()
        {
            throw new NotImplementedException();
        }
    }
}