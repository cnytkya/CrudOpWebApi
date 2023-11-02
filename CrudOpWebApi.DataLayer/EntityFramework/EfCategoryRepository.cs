using CrudOpWebApi.DataLayer.Abstract;
using CrudOpWebApi.DataLayer.Repository;
using CrudOpWebApi.EntityLayer.Entities;

namespace CrudOpWebApi.DataLayer.EntityFramework
{
    public class EfCategoryRepository : GenericRepository<Category>, ICategoryRepo
    {
    }
}
