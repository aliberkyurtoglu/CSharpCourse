using System.Collections.Generic;

namespace GameProject.Core
{
    public interface ICrudService<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
        List<T> GetAll();
        T GetById(int itemId);
    }
}