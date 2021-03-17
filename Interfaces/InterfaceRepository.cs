using System.Collections.Generic;

namespace CrudSeries.Interfaces
{
    public interface InterfaceRepository<T>
    {
         List<T> List();
         T ReturnById(int id);
         void Insert(T entity);
         void Delete(int id);
         void Update(int id, T entity);
         int NextId();
    }
}