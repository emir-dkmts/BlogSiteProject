namespace BlogSite.Models.Dtos.Posts.Requests;

public sealed record UpdateUserRequest(long Id, string FirstName, string LastName, string Email, string Username, string Password);