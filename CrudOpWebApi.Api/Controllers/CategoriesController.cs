using CrudOpWebApi.BusinessLayer.Manager;
using CrudOpWebApi.DataLayer.EntityFramework;
using CrudOpWebApi.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CrudOpWebApi.Controllers
{
    [Route("api/categories")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        CategoryManager cm = new CategoryManager(new EfCategoryRepository());

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categories = cm.GetList();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            var category = cm.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            return Ok(category);
        }

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            cm.Add(category);
            return CreatedAtAction(nameof(GetCategoryById), new { id = category.Id }, category);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCategory(int id, Category category)
        {
            var existingCategory = cm.GetById(id);

            if (existingCategory == null)
            {
                return NotFound();
            }

            category.Id = id;
            cm.Update(category);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var category = cm.GetById(id);

            if (category == null)
            {
                return NotFound();
            }

            cm.Delete(category);

            return NoContent();
        }
    }
}
