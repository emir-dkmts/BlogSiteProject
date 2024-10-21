using AutoMapper;
using BlogSite.Models.Dtos.Posts.Requests;
using BlogSite.Models.Dtos.Posts.Responses;
using BlogSite.Models.Entities;

namespace BlogSite.Service.Profiles;

public class MappingProfiles : Profile
{

    public MappingProfiles()
    {
        CreateMap<CreatePostRequest, Post>();
        CreateMap<UpdatePostRequest, Post>();
        CreateMap<Post, PostResponseDto>()
            .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name))
            .ForMember(x => x.UserName, opt => opt.MapFrom(X => X.Author.Username));


        CreateMap<CreateCategoryRequest, Category>();
        CreateMap<UpdateCategoryRequest, Category>();
        CreateMap<Category, CategoryResponseDto>()
            .ForMember(x => x.Name, opt => opt.MapFrom(x => x.Name));

        CreateMap<CreateCommentRequest, Comment>();
        CreateMap<UpdateCommentRequest, Comment>();
        CreateMap<Comment, CommentResponseDto>()
            .ForMember(x => x.Text, opt => opt.MapFrom(x => x.Text));

        CreateMap<CreateUserRequest, User>();
        CreateMap<UpdateUserRequest, User>();
        CreateMap<User, UserResponseDto>()
            .ForMember(x=>x.FirstName, opt=>opt.MapFrom(x => x.FirstName))
            .ForMember(x => x.LastName, opt => opt.MapFrom(x => x.LastName))
            .ForMember(x => x.Username, opt => opt.MapFrom(x => x.Username))
            .ForMember(x => x.Email, opt => opt.MapFrom(x => x.Email))
            .ForMember(x => x.Password, opt => opt.MapFrom(x => x.Password));


    }



}