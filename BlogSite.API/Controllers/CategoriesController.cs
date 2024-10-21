using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Service.Abstratcts;
using BlogSite.Service.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlogSite.API.Controllers;
[Route("api/[controller]")]
[ApiController]

public class CategoriesController(ICategoryService _categoryService) : ControllerBase
{

    [HttpGet("getallCategories")]
    public IActionResult GetAll()
    {
        var result = _categoryService.GetAll();
        return Ok(result);
    }

    [HttpPost("addCategories")]
    public IActionResult Add([FromBody] CreateCategoryRequest dto)
    {
        var result = _categoryService.Add(dto);
        return Ok(result);
    }

    [HttpGet("getCategorybyid/{id}")]
    public IActionResult GetById([FromRoute] int id)
    {
        var result = _categoryService.GetById(id);
        return Ok(result);
    }

    [HttpDelete("deleteCategory")]
    public IActionResult Delete([FromQuery] int id)
    {
        var result = _categoryService.Remove(id);
        return Ok(result);
    }

    [HttpPut("updateCategory")]
    public IActionResult Update([FromBody] UpdateCategoryRequest dto)
    {
        var result = _categoryService.Update(dto);
        return Ok(result);
    }

}