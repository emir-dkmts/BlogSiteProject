using AutoMapper;
using BlogSite.DataAccess.Abstracts;
using BlogSite.DataAccess.Concretes;
using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Models.Dtos.Posts.Responses;
using BlogSite.Models.Entities;
using BlogSite.Service.Abstratcts;
using Core.Responses;

namespace BlogSite.Service.Concretes;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public ReturnModel<CategoryResponseDto> Add(CreateCategoryRequest create)
    {
        Category createdCategory = _mapper.Map<Category>(create);
        _categoryRepository.Add(createdCategory);

        CategoryResponseDto response = _mapper.Map<CategoryResponseDto>(createdCategory);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Comment Eklendi.",
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<List<CategoryResponseDto>> GetAll()
    {
        List<Category> categories = _categoryRepository.GetAll();
        List<CategoryResponseDto> responses = _mapper.Map<List<CategoryResponseDto>>(categories);


        return new ReturnModel<List<CategoryResponseDto>>
        {
            Data = responses,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto?> GetById(int id)
    {
        var category = _categoryRepository.GetById(id);

        var response = _mapper.Map<CategoryResponseDto>(category);

        return new ReturnModel<CategoryResponseDto?>
        {
            Data = response,
            Message = string.Empty,
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto> Remove(int id)
    {
        Category category = _categoryRepository.GetById(id);
        Category deletedCategory = _categoryRepository.Remove(category);

        CategoryResponseDto response = _mapper.Map<CategoryResponseDto>(deletedCategory);

        return new ReturnModel<CategoryResponseDto>
        {
            Data = response,
            Message = "Comment Silindi.",
            StatusCode = 200,
            Success = true
        };
    }

    public ReturnModel<CategoryResponseDto> Update(UpdateCategoryRequest updateCategory)
    {
        Category category = _categoryRepository.GetById(updateCategory.Id);

        Category update = new Category
        {
            Name = updateCategory.Name,
        };

        Category updatedCategory = _categoryRepository.Update(update);

        CategoryResponseDto dto = _mapper.Map<CategoryResponseDto>(updatedCategory);
        return new ReturnModel<CategoryResponseDto>
        {
            Data = dto,
            Message = "Category güncellendi",
            StatusCode = 200,
            Success = true
        };
    }
}
