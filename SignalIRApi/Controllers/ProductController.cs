using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SignalIR.BusinessLayer.Abstract;
using SignalIR.DtoLayer.FeatureDto;
using SignalIR.DtoLayer.ProductDto;
using SignalIR.Entity_Layer.Entities;

namespace SignalIRApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

      
        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }
        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
            {
                ProductName=createProductDto.ProductName,
                Description=createProductDto.Description,
                Price=createProductDto.Price,
                Imageurl=createProductDto.Imageurl,
                ProductStatus=createProductDto.ProductStatus,
            });
            return Ok("İndirim Bilgisi Eklendi.");
        }
        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var values = _productService.TGetById(id);
            _productService.TDelete(values);
            return Ok("İletişim Bilgisi silindi.");
        }
        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
               ProductID=updateProductDto.ProductID,
               ProductName=updateProductDto.ProductName,
               Description=updateProductDto.Description,
               Price=updateProductDto.Price,
               Imageurl=updateProductDto.Imageurl,
               ProductStatus=updateProductDto.ProductStatus,
            });
            return Ok("İletişim Bilgisi Güncellendi..");
        }
        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }
    }
}
