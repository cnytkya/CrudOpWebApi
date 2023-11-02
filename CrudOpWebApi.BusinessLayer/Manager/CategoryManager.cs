using CrudOpWebApi.BusinessLayer.Service;
using CrudOpWebApi.DataLayer.Abstract;
using CrudOpWebApi.EntityLayer.Entities;

namespace CrudOpWebApi.BusinessLayer.Manager
{
    public class CategoryManager : ICategoryService
    {
        ICategoryRepo _categoryRepo;

        public CategoryManager(ICategoryRepo categoryDal)
        {
            _categoryRepo = categoryDal;
        }

        public void Add(Category t)
        {
            _categoryRepo.Insert(t);
        }

        public void Delete(Category t)
        {
            _categoryRepo.Delete(t);
        }

        public Category GetById(int id)
        {
            return _categoryRepo.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categoryRepo.GetListAll();
        }

        public void Update(Category t)
        {
            _categoryRepo.Update(t);
        }
    }

}
