namespace BlogSite.Models.Dtos.Posts.Requests;

public sealed record UpdateCommentRequest(Guid Id, string Text);