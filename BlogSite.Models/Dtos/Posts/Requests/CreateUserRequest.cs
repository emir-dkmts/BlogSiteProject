namespace BlogSite.Models.Dtos.Posts.Requests;

public record CreateUserRequest(string FirstName, string LastName, string Email, string Username, string Password);