using System.Linq;

namespace ApexResturant.Repository
{
    public interface IGenericrepository<T>{
        T Get(int id);
        IQueryable<T> Query();
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }

}