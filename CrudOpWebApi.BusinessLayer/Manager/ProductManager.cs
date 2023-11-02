using CrudOpWebApi.BusinessLayer.Service;
using CrudOpWebApi.DataLayer.Abstract;
using CrudOpWebApi.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOpWebApi.BusinessLayer.Manager
{
    public class ProductManager : IProductService
    {
        IProductRepo _repo;

        public ProductManager(IProductRepo repo)
        {
            _repo = repo;
        }

        public void Add(Product t)
        {
            _repo.Insert(t);
        }

        public void Delete(Product t)
        {
            _repo.Delete(t);
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }

        public List<Product> GetList()
        {
            return _repo.GetListAll();
        }

        public List<Product> GetProductsWithCategory()
        {
            return _repo.GetProductsWithCategory();
        }

        public void Update(Product t)
        {
            _repo.Update(t);
        }
    }
}
