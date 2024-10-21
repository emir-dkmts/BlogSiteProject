using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Models.Dtos.Posts.Responses;
using Core.Responses;

namespace BlogSite.Service.Abstratcts;

public interface IUserService
{
    ReturnModel<List<UserResponseDto>> GetAll();
    ReturnModel<UserResponseDto?> GetById(long id);
    ReturnModel<UserResponseDto> Add(CreateUserRequest create);

    ReturnModel<UserResponseDto> Update(UpdateUserRequest updateUser);

    ReturnModel<UserResponseDto> Remove(long id);
}
