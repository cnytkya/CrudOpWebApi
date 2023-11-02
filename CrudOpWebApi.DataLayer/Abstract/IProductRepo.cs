using CrudOpWebApi.EntityLayer.Entities;
using System.Reflection.Metadata;

namespace CrudOpWebApi.DataLayer.Abstract
{
    public interface IProductRepo : IGenericRepo<Product>
    {
        List<Product> GetProductsWithCategory();
    }
}
