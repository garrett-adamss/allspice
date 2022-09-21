using System.Collections.Generic;

namespace allspice.Repositories
{
    public interface IRepo<T, TId>
    {
        T Create(T body);
        List<T> GetAll();
        T GetById(TId id);
        T Update(T update);
        void Delete(TId id);
    }
}