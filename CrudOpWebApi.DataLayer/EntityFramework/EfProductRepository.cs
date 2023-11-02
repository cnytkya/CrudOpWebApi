using CrudOpWebApi.DataLayer.Abstract;
using CrudOpWebApi.DataLayer.Context;
using CrudOpWebApi.DataLayer.Repository;
using CrudOpWebApi.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace CrudOpWebApi.DataLayer.EntityFramework
{
    public class EfProductRepository : GenericRepository<Product>, IProductRepo
    {
        public List<Product> GetProductsWithCategory()
        {
            using (var c = new AppDbContext())
            {
                return c.Products.Include(x => x.Category).ToList();
            }
        }
    }
}
