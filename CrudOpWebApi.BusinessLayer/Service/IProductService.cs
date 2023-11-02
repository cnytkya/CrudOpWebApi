using CrudOpWebApi.DataLayer.Context;
using CrudOpWebApi.EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace CrudOpWebApi.BusinessLayer.Service
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> GetProductsWithCategory();
    }
}
