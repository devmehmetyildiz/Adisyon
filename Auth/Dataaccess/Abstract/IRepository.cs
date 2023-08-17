using System.Linq.Expressions;

namespace Auth.Dataaccess.Abstract
{
    public interface IRepository<Tentity> where Tentity : class
    {
        Tentity GetbyName(string Name);
        Tentity Getbyid(int id);
        List<Tentity> GetAll();
        List<Tentity> GetTop(int count);
        void Update(Tentity olditem, Tentity newitem);
        void Add(Tentity entity);
        void AddRange(List<Tentity> entities);
        void Remove(int id);
        void RemoveRange(List<Tentity> entities);
        T GetRecord<T>(Expression<Func<T, bool>> predicate) where T : class;
        List<T> GetRecords<T>(Expression<Func<T, bool>> predicate) where T : class;
    }
}
