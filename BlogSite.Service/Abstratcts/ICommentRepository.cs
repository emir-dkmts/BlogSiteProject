using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Models.Dtos.Posts.Responses;
using BlogSite.Models.Entities;
using Core.Responses;

namespace BlogSite.Service.Abstratcts;

public interface ICommentService
{
    ReturnModel<List<CommentResponseDto>> GetAll();
    ReturnModel<CommentResponseDto?> GetById(Guid id);
    ReturnModel<CommentResponseDto> Add(CreateCommentRequest create);

    ReturnModel<CommentResponseDto> Update(UpdateCommentRequest updateComment);

    ReturnModel<CommentResponseDto> Remove(Guid id);
}