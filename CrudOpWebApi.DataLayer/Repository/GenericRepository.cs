using CrudOpWebApi.DataLayer.Abstract;
using CrudOpWebApi.DataLayer.Context;
using System.Linq.Expressions;

namespace CrudOpWebApi.DataLayer.Repository
{
    public class GenericRepository<T> : IGenericRepo<T> where T : class
    {
        public void Delete(T item)
        {
            using var c = new AppDbContext();
            c.Remove(item);
            c.SaveChanges();
        }

        public T GetById(int id)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Find(id);
        }

        public List<T> GetListAll()
        {
            using var c = new AppDbContext();
            return c.Set<T>().ToList();
        }

        public void Insert(T item)
        {
            using var c = new AppDbContext();
            c.Add(item);
            c.SaveChanges();
        }

        public List<T> GetListAll(Expression<Func<T, bool>> filter)
        {
            using var c = new AppDbContext();
            return c.Set<T>().Where(filter).ToList();
        }

        public void Update(T item)
        {
            using var c = new AppDbContext();
            c.Update(item);
            c.SaveChanges();
        }
    }
}
