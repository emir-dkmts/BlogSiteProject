namespace BlogSite.Models.Dtos.Posts.Requests;

public record CreateCommentRequest(string Text, long UserId, Guid PostId);