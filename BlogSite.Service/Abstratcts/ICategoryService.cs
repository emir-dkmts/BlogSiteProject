using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Models.Dtos.Posts.Responses;
using Core.Responses;
using BlogSite.Models.Entities;

namespace BlogSite.Service.Abstratcts;

public interface ICategoryService
{
    ReturnModel<List<CategoryResponseDto>> GetAll();
    ReturnModel<CategoryResponseDto?> GetById(int id);
    ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create);

    ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest updateCategory);

    ReturnModel<CategoryResponseDto> Remove(int id);
}
