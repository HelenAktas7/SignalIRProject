using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.BusinessLayer.Abstract;
using SignalIR.DtoLayer.CategoryDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoryController(ICategoryService categoryService,IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult CategoryList() { 
        var value=_mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetListAll());
        return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto) {
            _categoryService.TAdd(new Category()
            {
               Name= createCategoryDto.Name,
               Status= createCategoryDto.Status
            });
            return Ok("Kategori Eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteCategory(int id) { 
        var values=_categoryService.TGetById(id);
            _categoryService.TDelete(values);
            return Ok("Kategori silindi.");
        }
        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            { 

               Name = updateCategoryDto.Name,
               CategoryID = updateCategoryDto.CategoryID,
               Status = updateCategoryDto.Status
               });
            return Ok("Kategori Güncellendi..");
        }
        [HttpGet]
        public IActionResult GetCategory(int id) { 
        var value=_categoryService.TGetById(id);
            return Ok(value);
        }
    }
}
