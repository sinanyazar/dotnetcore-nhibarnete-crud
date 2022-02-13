using BLL.Interface;
//using Entities.Model.EfCoreModel;
using Microsoft.AspNetCore.Mvc;
using Entities.Model.NHibarnateModel;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        ICategoryService<Category> _categoryService;

        public CategoryController(ICategoryService<Category> categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _categoryService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}